using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace PostCodeLookup
{
    public partial class Form1 : Form
    {
        #region Private Variables
        private List<ClsAddress> addressList = new List<ClsAddress>();
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Get Address button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetAddress_Click(object sender, EventArgs e)
        {
            this.ClearBasicControls();

            //Retrieve and set a post code value to a variable.
            string postCodeHolder;
            
            postCodeHolder = this.txtBasicPostCode.Text;

            string url =
                String.Format("http://pcls1.craftyclicks.co.uk/xml/basicaddress?postcode={0}&response=data_formatted",
                    postCodeHolder);
           
            //Complete XML HTTP Request
            WebRequest request = WebRequest.Create(url);
            //Complete XML HTTP Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Declare and set a stream reader to read the returned XML
            StreamReader reader = new StreamReader(response.GetResponseStream());

            //Declare and set XML document, loading in the XML from the stream reader.
            XmlDocument xmlDoc = new XmlDocument();
           
            xmlDoc.LoadXml(reader.ReadToEnd());

            //Attempt to set the node list to the address details node (thoroughfare).
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/CraftyResponse/address_data_formatted/thoroughfare");
          

            if (xmlNodeList.Count > 0)
            {
                //If the node list contains address nodes then move on.
                int i = 0;
                foreach (System.Xml.XmlNode node in xmlNodeList)
                {
                    ClsAddress address = new ClsAddress()
                    {
                        AddressID = i,
                        AddressLine1 = node.ChildNodes[0].InnerText,
                        AddressLine2 = node.ChildNodes[1].InnerText,
                        County =
                            xmlDoc.SelectSingleNode("CraftyResponse/address_data_formatted/postal_county").InnerText,
                        PostCode = xmlDoc.SelectSingleNode("CraftyResponse/address_data_formatted/postcode").InnerText,
                        Town = xmlDoc.SelectSingleNode("/CraftyResponse/address_data_formatted/town").InnerText
                    };

                    addressList.Add(address);
                    i++;
                }

                this.DisplayAddressDetails();

            }
            else
            {
                //If no node details, there will be an error message. 

                xmlNodeList = xmlDoc.SelectNodes("/CraftyResponse"); //Populate the nodelist with the error info

                foreach (System.Xml.XmlNode node in xmlNodeList)
                {
                    // Get the details of the error message and return it the user.

                    switch (node.ChildNodes[0].InnerText)
                    {
                        case "0001":
                            MessageBox.Show("Post Code not found");
                            break;
                        case "0002":
                            MessageBox.Show("Invalid Post Code format");
                            break;
                        case "7001":
                            MessageBox.Show("Demo limit exceeded");
                            break;
                        case "8001":
                            MessageBox.Show("Invalid or no access token");
                            break;
                        case "8003":
                            MessageBox.Show("Account credit allowance exceeded");
                            break;
                        case "8004":
                            MessageBox.Show("Access denied due to access rules");
                            break;
                        case "8005":
                            MessageBox.Show("Access denied, account suspended");
                            break;
                        case "9001":
                            MessageBox.Show("Internal server error");
                            break;
                        default:
                            MessageBox.Show("Unknown Error");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Get Rapid Addresses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRapidGetAddresses_Click(object sender, EventArgs e)
        {
            this.ClearRapidControls();

            //Retrieve and set a post code value to a variable.
            string postCodeHolder;
            postCodeHolder = this.txtBasicPostCode.Text;


            string url =
              String.Format("http://pcls1.craftyclicks.co.uk/xml/rapidaddress?postcode={0}&response=data_formatted&lines=2",
                  postCodeHolder);

            //Complete XML HTTP Request
            WebRequest request = WebRequest.Create(url);
            //Complete XML HTTP Response
            WebResponse response = request.GetResponse();

            //Declare and set a stream reader to read the returned XML
            StreamReader reader = new StreamReader(response.GetResponseStream());

            //Declare and set XML document, loading in the XML from the stream reader.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(reader.ReadToEnd());
            //Declare and set an xmlnode list to hold the address details.
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/CraftyResponse/address_data_formatted/delivery_point");
            //Attempt to set the node list to the address details node (thoroughfare).

            if (xmlNodeList.Count > 0)
            {
                //If the node list contains address nodes then move on.
                int i = 0;
                foreach (System.Xml.XmlNode node in xmlNodeList)
                {
                    ClsAddress address = new ClsAddress()
                    {
                        AddressID = i,
                        AddressLine1 = node.ChildNodes[2].InnerText,
                        AddressLine2 = node.ChildNodes[3].InnerText,
                        County =
                            xmlDoc.SelectSingleNode("CraftyResponse/address_data_formatted/postal_county").InnerText,
                        PostCode = xmlDoc.SelectSingleNode("CraftyResponse/address_data_formatted/postcode").InnerText,
                        Town = xmlDoc.SelectSingleNode("/CraftyResponse/address_data_formatted/town").InnerText
                    };

                    addressList.Add(address);
                    i++;
                }

                this.LoadAddressListIntoDropDown();

            }
            else
            {
                //If no node details, there will be an error message. 

                xmlNodeList = xmlDoc.SelectNodes("/CraftyResponse"); //Populate the nodelist with the error info

                foreach (System.Xml.XmlNode node in xmlNodeList)
                {
                    // Get the details of the error message and return it the user.

                    switch (node.ChildNodes[0].InnerText)
                    {
                        case "0001":
                            MessageBox.Show("Post Code not found");
                            break;
                        case "0002":
                            MessageBox.Show("Invalid Post Code format");
                            break;
                        case "7001":
                            MessageBox.Show("Demo limit exceeded");
                            break;
                        case "8001":
                            MessageBox.Show("Invalid or no access token");
                            break;
                        case "8003":
                            MessageBox.Show("Account credit allowance exceeded");
                            break;
                        case "8004":
                            MessageBox.Show("Access denied due to access rules");
                            break;
                        case "8005":
                            MessageBox.Show("Access denied, account suspended");
                            break;
                        case "9001":
                            MessageBox.Show("Internal server error");
                            break;
                        default:
                            MessageBox.Show("Unknown Error");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Address list changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAddressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(cboAddressList.SelectedValue);

            this.txtRapidAL1.Text = addressList[index].AddressLine1;
            this.txtRapidAL2.Text = addressList[index].AddressLine2;
            this.txtRapidCity.Text = addressList[index].Town;
            this.txtRapidCounty.Text = addressList[index].County;
            this.txtRapidPC.Text = addressList[index].PostCode;
        }
#endregion

        #region Private Methods

        private void DisplayAddressDetails()
        {
            this.txtBasicAL1.Text = addressList[0].AddressLine1;
            this.txtBasicAL2.Text = addressList[0].AddressLine2;
            this.txtBasicCity.Text = addressList[0].Town;
            this.txtBasicCounty.Text = addressList[0].County;
            this.txtBasicPC.Text = addressList[0].PostCode;
        }

        private void ClearBasicControls()
        {
            this.txtBasicHouseNo.Text = "";
            this.txtBasicAL1.Text = "";
            this.txtBasicAL2.Text = "";
            this.txtBasicCity.Text = "";
            this.txtBasicCounty.Text = "";
            this.txtBasicPC.Text = "";
        }
        
        private void LoadAddressListIntoDropDown()
        {
            this.cboAddressList.Items.Clear();
            this.cboAddressList.DisplayMember = "AddressLine1";
            this.cboAddressList.ValueMember = "AddressID";
            this.cboAddressList.DataSource = addressList;
        }

        private void ClearRapidControls()
        {
            this.txtRapidAL1.Text = "";
            this.txtRapidAL2.Text = "";
            this.txtRapidCity.Text = ";";
            this.txtRapidCounty.Text = "";
            this.txtRapidPC.Text = "";
        }

        #endregion
    }
}
