using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SplitFileXML
{
    public partial class Default : System.Web.UI.Page
    {
        string pathFile = ConfigurationManager.AppSettings["PathFile"];

         string pathFileOut = ConfigurationManager.AppSettings["PathFileOut"];
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(pathFile);
            XDeclaration declaration = doc.Declaration;
            TxtFile.Text = declaration.ToString()+ "\n"+  doc.ToString();
        }

        protected void BtnSplit_Click(object sender, EventArgs e)
        {
            SplitFileXML(pathFile);
            LblShowMessage.Text = "file XML is splitted ";
            LblShowMessage.ForeColor = Color.Green;
            LblShowMessage.Visible = true;
        }

        private void SplitFileXML(string url)
        {
            XDocument doc = XDocument.Load(url);

            XDeclaration declaration = doc.Declaration;
            string nouedToSplit = TxtTag.Text;

           
            IEnumerable<XDocument> newDocs = doc.Descendants(nouedToSplit)
                 .Select(d => new XDocument(new XElement(doc.Root.Name.ToString(), d)));

           
            XDocument[] tabDoc = newDocs.ToArray();
            StringBuilder text = new StringBuilder();
            for (int i = 0 ; i < tabDoc.Length; i++)    
            {
                tabDoc[i].Declaration = declaration;
                tabDoc[i].Save(pathFileOut +" noued  "+ (i+1)+ ".xml" );

                text.Append("\n---------------------------------------------------------------\n");

                text.Append(tabDoc[i].Declaration.ToString() + "\n");
                text.Append(tabDoc[i].ToString());

            }
            TxtFileSplit.Text = text.ToString();

        }

      

    }
}