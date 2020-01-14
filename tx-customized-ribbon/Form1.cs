using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXTextControl.DocumentServer.DataSources;
using TXTextControl.Windows.Forms.Ribbon;

namespace tx_customized_ribbon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dynamic joData = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            joData = JsonConvert.DeserializeObject(File.ReadAllText("data.json"));

            ribbonReportingTab1.DataSourceManager.LoadJson(joData.ToString());
            ribbonReportingTab1.DataSourceManager.PossibleMergeFieldColumnsChanged += 
                DataSourceManager_PossibleMergeFieldColumnsChanged;

            //MaskDataColumnNames(joData);
        }

        private void DataSourceManager_PossibleMergeFieldColumnsChanged(object sender, EventArgs e)
        {
            MaskDataColumnNames(joData);
        }

        private void MaskDataColumnNames(dynamic data)
        {
            // flatten data object in of an array
            if (data.GetType() == typeof(JArray))
                data = data[0];

            // find merge fields ribbon menu button
            RibbonMenuButton ctlInsertMergeFields =
                ribbonReportingTab1.FindItem(
                    RibbonReportingTab.RibbonItem.TXITEM_InsertMergeField)
                    as RibbonMenuButton;

            // get the selected master table info
            DataTableInfo dataTableInfo =
                ribbonReportingTab1.DataSourceManager.MasterDataTableInfo;

            // select token in data object
            if (dataTableInfo.TableName != "RootTable")
            {
                data = data.SelectToken("$.." + dataTableInfo.TableName);
            }
                
            // change the strings
            ApplyMaskedString(ctlInsertMergeFields.DropDownItems, data);           
        }

        private void ApplyMaskedString(RibbonItemCollection ribbonItems, dynamic data)
        {
            // flatten data object in of an array
            if (data.GetType() == typeof(JArray))
                data = data[0];

            // loop through all ribbon items in the "insert merge fields" menu
            foreach (Control ribbonButton in ribbonItems)
            {
                // in case, the item is a drop-down, call ApplyMaskedString
                // recursively with a new data object
                if (ribbonButton is RibbonMenuButton)
                {
                    ApplyMaskedString(
                        ((RibbonMenuButton)ribbonButton).DropDownItems,
                        data[ribbonButton.Text]);
                }
                // in case it is a merge field insert button
                else if (ribbonButton is RibbonButton)
                {
                    // and it is not a separator or title
                    if (!ribbonButton.Name.StartsWith("TXITEM_"))
                    {
                        // get the data from the first data row
                        var dataValue = data[ribbonButton.Text];

                        if (dataValue == null)
                            continue;

                        if (dataValue.GetType() == typeof(JValue))
                        { 
                            // change the actual text
                            ribbonButton.Text = dataValue.Value;
                        }
                    }
                }
            }
        }
    }
}
