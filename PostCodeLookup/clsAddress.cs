namespace PostCodeLookup
{
   public class ClsAddress
   {
       #region Private variables

       private int _mAddressId;
       private string _mAddressLine1;
       private string _mAddressLine2;
       private string _mTown;
       private string _mCounty;
       private string _mPostCode;

       #endregion

       #region Constructor
       public ClsAddress()
       {

       }

       #endregion

       #region Properties

       public int AddressID
       {
           get { return this._mAddressId; }
           set { this._mAddressId = value; }
       }

       public string AddressLine1
       {
           get { return this._mAddressLine1; }
           set { this._mAddressLine1 = value; }
       }

       public string AddressLine2
       {
           get { return this._mAddressLine2; }
           set { this._mAddressLine2 = value; }
       }

       public string Town
       {
           get { return this._mTown; }
           set { this._mTown = value; }
       }

       public string County
       {
           get { return this._mCounty; }
           set { this._mCounty = value; }
       }

       public string PostCode
       {
           get { return this._mPostCode; }
           set { this._mPostCode = value; }
       }
       #endregion
   }
}
