using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace New
{
    public partial class Main : Form
    {
        string _filename = "";
        public Main()
        {
            InitializeComponent();
        }

        public int ReadFileToBase(string path_File)
        {
            int rel = 0;
            try
            {
                int recordType = 0;
                string record = "";
                string btranID = "";
                //Path file
                string[] lines = System.IO.File.ReadAllLines(path_File);
                /*
                 * Read file
                 * Record type:
                 *   0 : file header - no
                 *   1 : batch header - yes
                 *   2 : trasaction detail - yes
                 *   7 : batch trailer - yes
                 *   9 : file trailer - yes
                 */
                int irecord = 0;
                foreach (string iline in lines)
                {
                    lbListRow.Items.Add(iline);

                    recordType = int.Parse(iline.Substring(0,1));
                    if (recordType != 0 && recordType != 9)
                    {
                        
                        irecord = irecord + 1;
                        string tmp = "00000000" + irecord.ToString();
                        btranID = "BID" + tmp.PadRight(8);
                        record = iline.Substring(38,iline.Length - 38).ToString();
                        lbListRel.Items.Add(record);

                        //
                        // Add subitem
                        ListViewItem Items = new ListViewItem();
                        Items.Text = btranID;
                        Items.SubItems.Add(record.Substring(0, 10));
                        int iCR = record.IndexOf("CR");
                        int iDR = record.IndexOf("DR");
                        if ( iCR > 0)
                        {
                            Items.SubItems.Add(record.Substring(10, iCR - 10));
                            Items.SubItems.Add(record.Substring(iCR, 2));
                            if (iCR + 2 != record.Length - 1)
                            {
                                Items.SubItems.Add(record.Substring(iCR + 2, 2));
                                Items.SubItems.Add(record.Substring(iCR + 4, record.Length - iCR -5));
                            }
                            else
                            {
                                Items.SubItems.Add("");
                                Items.SubItems.Add("");
                                
                            }
                            Items.SubItems.Add(DateTime.Now.ToShortDateString());
                        }
                        else if ( iDR> 0)
                        {
                            Items.SubItems.Add(record.Substring(10, iDR - 10));
                            Items.SubItems.Add(record.Substring(iDR , 2));
                            if (iDR + 2 != record.Length - 1)
                            {
                                Items.SubItems.Add(record.Substring(iDR + 2, 2));
                                Items.SubItems.Add(record.Substring(iDR + 4, record.Length - iDR - 5));
                            }
                            else
                            {
                                Items.SubItems.Add("");
                                Items.SubItems.Add("");
                                

                            }
                            Items.SubItems.Add(DateTime.Now.ToShortDateString());

                        }
                        
                        listView.Items.Add(Items);
                    }
                }
            }
            catch (Exception ex)
            {
                return rel = -1;
                throw new Exception(ex.Message);
            }
            return rel;
        }

        private void CreateListView()
        {
            listView.Columns.Add("btranID", 100);
            listView.Columns.Add("btranDate", 100);
            listView.Columns.Add("btranAmount", 100);
            listView.Columns.Add("btranCRDR", 100);
            listView.Columns.Add("btranTrCode", 100);
            listView.Columns.Add("btranTrDescRef",100);
            listView.Columns.Add("btranCreated", 100);

            listView.View = View.Details;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string _filename = "";
            openFileDialog1.FileName = "";

            CreateListView();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filename = openFileDialog1.FileName;
                txtname.Text = _filename;
                ReadFileToBase(_filename);
            }
        }

        
    }
}
