using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiraggoEdmx_v2;
using TiraggoEdmx_v3;

namespace ReadEdmxFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            codeWindow.Text = "";

            TiraggoEdmx_v2.Edmx edmx_v2 = TiraggoEdmx_v2.Edmx.Load(@".\EdmxFiles\V2\Model1.edmx_");

            // Get the information about the "Collaborator" table
            TiraggoEdmx_v2.TiraggoEntityInfo v2_info = new TiraggoEdmx_v2.TiraggoEntityInfo(edmx_v2, "My2ndGenerationModel.CollaboratorInvite");

            string attributes = "";

            string text = "// Physical Table [" + v2_info.StorageInfo.Schema + "." + v2_info.StorageInfo.Name + "]" + Environment.NewLine;
            text += "public partial class " + v2_info.ConceptualModel.Name + Environment.NewLine;
            text += "{" + Environment.NewLine;

            foreach (TiraggoEdmx_v2.tgProperty prop in v2_info.ConceptualModel.Properties)
            {
                attributes = "";

                // Determine Attributes
                if (v2_info.IsInPrimaryKey(prop.Name))
                {
                    attributes += "\t[Key]" + Environment.NewLine;
                }

                if (prop.NullableSpecified && !prop.Nullable)
                {
                    attributes += "\t[Required]" + Environment.NewLine;
                }

                string phyicalName = v2_info.ColumnMappings[prop.Name];
                TiraggoEdmx_v2.tgProperty sqlInfo = v2_info.ColumnSQL[phyicalName];
                text += "\t// Physical SQL Column [" + sqlInfo.Name + "], Type [" + sqlInfo.Type + "]" + Environment.NewLine;

                if (!string.IsNullOrWhiteSpace(attributes))
                {
                    text += attributes;
                }

                text += "\tpublic " + prop.Type + " " + prop.Name + " { get; set; }" + Environment.NewLine + Environment.NewLine;
            }

            text += "}" + Environment.NewLine;

            codeWindow.Text = text;
        }

        private void btnV3_Click(object sender, EventArgs e)
        {
            codeWindow.Text = "";

            TiraggoEdmx_v3.Edmx edmx_v3 = TiraggoEdmx_v3.Edmx.Load(@".\EdmxFiles\V3\Model1.edmx_");

            // Get the information about the "Collaborator" table
            TiraggoEdmx_v3.TiraggoEntityInfo v3_info = new TiraggoEdmx_v3.TiraggoEntityInfo(edmx_v3, "My2ndGenerationModel.ForeignKey");

            string attributes = "";

            string text = "// Physical Table [" + v3_info.StorageInfo.Schema + "." + v3_info.StorageInfo.Name + "]" + Environment.NewLine;
            text += "public partial class " + v3_info.ConceptualModel.Name + Environment.NewLine;
            text += "{" + Environment.NewLine;

            foreach (TiraggoEdmx_v3.tgProperty prop in v3_info.ConceptualModel.Properties)
            {
                attributes = "";

                // Determine Attributes
                if (v3_info.IsInPrimaryKey(prop.Name))
                {
                    attributes += "\t[Key]" + Environment.NewLine;
                }

                if (prop.NullableSpecified && !prop.Nullable)
                {
                    attributes += "\t[Required]" + Environment.NewLine;
                }


                string phyicalName = v3_info.ColumnMappings[prop.Name];
                TiraggoEdmx_v3.tgProperty sqlInfo = v3_info.ColumnSQL[phyicalName];
                text += "\t// Physical SQL Column [" + sqlInfo.Name + "], Type [" + sqlInfo.Type + "]" + Environment.NewLine;

                if (!string.IsNullOrWhiteSpace(attributes))
                {
                    text += attributes;
                }

                text += "\tpublic " + prop.Type + " " + prop.Name + " { get; set; }" + Environment.NewLine + Environment.NewLine;
            }

            text += "}" + Environment.NewLine;

            codeWindow.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            codeWindow.ConfigurationManager.Language = "cs";
            codeWindow.ConfigurationManager.Configure();

            LinkLabel.Link link = new LinkLabel.Link();
	        link.LinkData = "http://brewdawg.github.io/Tiraggo.Edmx/";
	        this.lnkTiraggoEdmx.Links.Add(link);

            link = new LinkLabel.Link();
	        link.LinkData = "http://brewdawg.github.io/Tiraggo.EF/";
	        this.lnkTiraggoEF.Links.Add(link);
        }

        private void lnkTiraggoEF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void lnkTiraggoEdmx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
