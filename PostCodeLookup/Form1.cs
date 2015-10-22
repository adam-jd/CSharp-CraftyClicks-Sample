using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

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
            var postCodeHolder = this.txtBasicPostCode.Text;

            string url =
                String.Format("http://pcls1.craftyclicks.co.uk/json/basicaddress?postcode={0}&response=data_formatted",
                    postCodeHolder);

            //Complete XML HTTP Request
            WebRequest request = WebRequest.Create(url);
            //Complete XML HTTP Response
            WebResponse response = request.GetResponse();

            //Declare and set a stream reader to read the returned XML
            StreamReader reader = new StreamReader(response.GetResponseStream());

            // Get the requests json object and convert it to in memory dynamic
            // Note: that you are able to convert to a specific object if required.
            var jsonResponseObject = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());

            // check that there are thoroughfare
            if (jsonResponseObject.thoroughfare_count > 0)
            {
                //If the node list contains address nodes then move on.
                int i = 0;
                foreach (var node in jsonResponseObject.thoroughfares)
                {
                    ClsAddress address = new ClsAddress()
                    {
                        AddressID = i,
                        AddressLine1 = node.line_1,
                        AddressLine2 = node.line_2,
                        County = jsonResponseObject.postal_county,
                        PostCode = jsonResponseObject.postcode,
                        Town = jsonResponseObject.town
                    };

                    addressList.Add(address);
                    i++;
                }

                this.DisplayAddressDetails();

            }
            else
            {
                //If no node details, there will be an error message. 

                foreach (var node in jsonResponseObject)
                {
                    // Get the details of the error message and return it the user.

                    switch ((string)node.Value)
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
                            MessageBox.Show((string)node.Value);
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
            postCodeHolder = this.txtRapidPostCode.Text;


            string url =
              String.Format("http://pcls1.craftyclicks.co.uk/json/rapidaddress?postcode={0}&response=data_formatted&lines=2",
                  postCodeHolder);
            

            //Complete XML HTTP Request
            WebRequest request = WebRequest.Create(url);
            //Complete XML HTTP Response
            WebResponse response = request.GetResponse();

            //Declare and set a stream reader to read the returned XML
            StreamReader reader = new StreamReader(response.GetResponseStream());

            // Get the requests json object and convert it to in memory dynamic
            // Note: that you are able to convert to a specific object if required.
           var jsonResponseObject = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
            
            // check that there are delivery points
            if (jsonResponseObject.delivery_point_count > 0)
            {
            
                //If the node list contains address nodes then move on.
                int i = 0;
                foreach (var node in jsonResponseObject.delivery_points)
                {
                    ClsAddress address = new ClsAddress()
                    {
                        AddressID = i,
                        AddressLine1 = node.line_1,
                        AddressLine2 = node.line_2,
                        County = jsonResponseObject.postal_county,
                        PostCode = jsonResponseObject.postcode,
                        Town = jsonResponseObject.town
                    };

                    addressList.Add(address);
                    i++;
                }

                this.LoadAddressListIntoDropDown();
            }
            else
            {
                //If no node details, there will be an error message. 

                foreach (var node in jsonResponseObject)
                {
                    // Get the details of the error message and return it the user.
                    switch ((string)node.Value)
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
                            MessageBox.Show((string)node.Value);
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
