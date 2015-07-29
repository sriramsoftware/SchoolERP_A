/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/20/2012 3:13:12 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSVendorDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_VendorDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _vdVendorId;
	private System.Int64? _vdVendorManagerId;
	private System.String _vdVendorDetailsId;
	private System.String _vdVendorName;
	private System.String _vdReleaventShop;
	private System.String _vdContactNo;
	private System.String _vdAlternateNumber;
	private System.Int64? _vdAddressId;
	private System.String _vdShopImage;
	private System.String _vdShopMap;
	private System.String _vdVendorImage;
	private System.String _vdVendorForPrePrimary;
	private System.String _vdVendorForPrimary;
	private System.String _vdVendorForHighSchool;
	private System.String _vdVendorForHouseUniform;
	private System.String _vdVendorSchoolUniform;
	private System.String _vdVendorSchoolShoes;
	private System.String _vdVendorSchoolBooks;
	private System.String _vdVendorSchoolBags;
	private System.String _vdVendorForBoys;
	private System.String _vdVendorForGirls;
	private System.DateTime? _vdDate;
	private System.String _vdWebsite;
	private System.Int32? _vdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? VDVendorId
	{
		get
		{
			return _vdVendorId;
		}
		set
		{
			_vdVendorId = value;
		}
	}
	
	public System.Int64? VDVendorManagerId
	{
		get
		{
			return _vdVendorManagerId;
		}
		set
		{
			_vdVendorManagerId = value;
		}
	}
	
	public System.String VDVendorDetailsId
	{
		get
		{
			return _vdVendorDetailsId;
		}
		set
		{
			_vdVendorDetailsId = value;
		}
	}
	
	public System.String VDVendorName
	{
		get
		{
			return _vdVendorName;
		}
		set
		{
			_vdVendorName = value;
		}
	}
	
	public System.String VDReleaventShop
	{
		get
		{
			return _vdReleaventShop;
		}
		set
		{
			_vdReleaventShop = value;
		}
	}
	
	public System.String VDContactNo
	{
		get
		{
			return _vdContactNo;
		}
		set
		{
			_vdContactNo = value;
		}
	}
	
	public System.String VDAlternateNumber
	{
		get
		{
			return _vdAlternateNumber;
		}
		set
		{
			_vdAlternateNumber = value;
		}
	}
	
	public System.Int64? VDAddressId
	{
		get
		{
			return _vdAddressId;
		}
		set
		{
			_vdAddressId = value;
		}
	}
	
	public System.String VDShopImage
	{
		get
		{
			return _vdShopImage;
		}
		set
		{
			_vdShopImage = value;
		}
	}
	
	public System.String VDShopMap
	{
		get
		{
			return _vdShopMap;
		}
		set
		{
			_vdShopMap = value;
		}
	}
	
	public System.String VDVendorImage
	{
		get
		{
			return _vdVendorImage;
		}
		set
		{
			_vdVendorImage = value;
		}
	}
	
	public System.String VDVendorForPrePrimary
	{
		get
		{
			return _vdVendorForPrePrimary;
		}
		set
		{
			_vdVendorForPrePrimary = value;
		}
	}
	
	public System.String VDVendorForPrimary
	{
		get
		{
			return _vdVendorForPrimary;
		}
		set
		{
			_vdVendorForPrimary = value;
		}
	}
	
	public System.String VDVendorForHighSchool
	{
		get
		{
			return _vdVendorForHighSchool;
		}
		set
		{
			_vdVendorForHighSchool = value;
		}
	}
	
	public System.String VDVendorForHouseUniform
	{
		get
		{
			return _vdVendorForHouseUniform;
		}
		set
		{
			_vdVendorForHouseUniform = value;
		}
	}
	
	public System.String VDVendorSchoolUniform
	{
		get
		{
			return _vdVendorSchoolUniform;
		}
		set
		{
			_vdVendorSchoolUniform = value;
		}
	}
	
	public System.String VDVendorSchoolShoes
	{
		get
		{
			return _vdVendorSchoolShoes;
		}
		set
		{
			_vdVendorSchoolShoes = value;
		}
	}
	
	public System.String VDVendorSchoolBooks
	{
		get
		{
			return _vdVendorSchoolBooks;
		}
		set
		{
			_vdVendorSchoolBooks = value;
		}
	}
	
	public System.String VDVendorSchoolBags
	{
		get
		{
			return _vdVendorSchoolBags;
		}
		set
		{
			_vdVendorSchoolBags = value;
		}
	}
	
	public System.String VDVendorForBoys
	{
		get
		{
			return _vdVendorForBoys;
		}
		set
		{
			_vdVendorForBoys = value;
		}
	}
	
	public System.String VDVendorForGirls
	{
		get
		{
			return _vdVendorForGirls;
		}
		set
		{
			_vdVendorForGirls = value;
		}
	}
	
	public System.DateTime? VDDate
	{
		get
		{
			return _vdDate;
		}
		set
		{
			_vdDate = value;
		}
	}
	
	public System.String VDWebsite
	{
		get
		{
			return _vdWebsite;
		}
		set
		{
			_vdWebsite = value;
		}
	}
	
	public System.Int32? VDStatus
	{
		get
		{
			return _vdStatus;
		}
		set
		{
			_vdStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorDetailsId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_ReleaventShop", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_ContactNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_AlternateNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_ShopImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_ShopMap", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForPrePrimary", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForPrimary", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForHighSchool", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForHouseUniform", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorSchoolUniform", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorSchoolShoes", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorSchoolBooks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorSchoolBags", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForBoys", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VendorForGirls", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_Website", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (VDVendorId == null)
		dr["VD_VendorId"] = DBNull.Value;
		else
		dr["VD_VendorId"] = VDVendorId;
		
		if (VDVendorManagerId == null)
		dr["VD_VendorManagerId"] = DBNull.Value;
		else
		dr["VD_VendorManagerId"] = VDVendorManagerId;
		
		if (VDVendorDetailsId == null)
		dr["VD_VendorDetailsId"] = DBNull.Value;
		else
		dr["VD_VendorDetailsId"] = VDVendorDetailsId;
		
		if (VDVendorName == null)
		dr["VD_VendorName"] = DBNull.Value;
		else
		dr["VD_VendorName"] = VDVendorName;
		
		if (VDReleaventShop == null)
		dr["VD_ReleaventShop"] = DBNull.Value;
		else
		dr["VD_ReleaventShop"] = VDReleaventShop;
		
		if (VDContactNo == null)
		dr["VD_ContactNo"] = DBNull.Value;
		else
		dr["VD_ContactNo"] = VDContactNo;
		
		if (VDAlternateNumber == null)
		dr["VD_AlternateNumber"] = DBNull.Value;
		else
		dr["VD_AlternateNumber"] = VDAlternateNumber;
		
		if (VDAddressId == null)
		dr["VD_AddressId"] = DBNull.Value;
		else
		dr["VD_AddressId"] = VDAddressId;
		
		if (VDShopImage == null)
		dr["VD_ShopImage"] = DBNull.Value;
		else
		dr["VD_ShopImage"] = VDShopImage;
		
		if (VDShopMap == null)
		dr["VD_ShopMap"] = DBNull.Value;
		else
		dr["VD_ShopMap"] = VDShopMap;
		
		if (VDVendorImage == null)
		dr["VD_VendorImage"] = DBNull.Value;
		else
		dr["VD_VendorImage"] = VDVendorImage;
		
		if (VDVendorForPrePrimary == null)
		dr["VD_VendorForPrePrimary"] = DBNull.Value;
		else
		dr["VD_VendorForPrePrimary"] = VDVendorForPrePrimary;
		
		if (VDVendorForPrimary == null)
		dr["VD_VendorForPrimary"] = DBNull.Value;
		else
		dr["VD_VendorForPrimary"] = VDVendorForPrimary;
		
		if (VDVendorForHighSchool == null)
		dr["VD_VendorForHighSchool"] = DBNull.Value;
		else
		dr["VD_VendorForHighSchool"] = VDVendorForHighSchool;
		
		if (VDVendorForHouseUniform == null)
		dr["VD_VendorForHouseUniform"] = DBNull.Value;
		else
		dr["VD_VendorForHouseUniform"] = VDVendorForHouseUniform;
		
		if (VDVendorSchoolUniform == null)
		dr["VD_VendorSchoolUniform"] = DBNull.Value;
		else
		dr["VD_VendorSchoolUniform"] = VDVendorSchoolUniform;
		
		if (VDVendorSchoolShoes == null)
		dr["VD_VendorSchoolShoes"] = DBNull.Value;
		else
		dr["VD_VendorSchoolShoes"] = VDVendorSchoolShoes;
		
		if (VDVendorSchoolBooks == null)
		dr["VD_VendorSchoolBooks"] = DBNull.Value;
		else
		dr["VD_VendorSchoolBooks"] = VDVendorSchoolBooks;
		
		if (VDVendorSchoolBags == null)
		dr["VD_VendorSchoolBags"] = DBNull.Value;
		else
		dr["VD_VendorSchoolBags"] = VDVendorSchoolBags;
		
		if (VDVendorForBoys == null)
		dr["VD_VendorForBoys"] = DBNull.Value;
		else
		dr["VD_VendorForBoys"] = VDVendorForBoys;
		
		if (VDVendorForGirls == null)
		dr["VD_VendorForGirls"] = DBNull.Value;
		else
		dr["VD_VendorForGirls"] = VDVendorForGirls;
		
		if (VDDate == null)
		dr["VD_Date"] = DBNull.Value;
		else
		dr["VD_Date"] = VDDate;
		
		if (VDWebsite == null)
		dr["VD_Website"] = DBNull.Value;
		else
		dr["VD_Website"] = VDWebsite;
		
		if (VDStatus == null)
		dr["VD_Status"] = DBNull.Value;
		else
		dr["VD_Status"] = VDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		VDVendorId = dr["VD_VendorId"] != DBNull.Value ? Convert.ToInt64(dr["VD_VendorId"]) : VDVendorId = null;
		VDVendorManagerId = dr["VD_VendorManagerId"] != DBNull.Value ? Convert.ToInt64(dr["VD_VendorManagerId"]) : VDVendorManagerId = null;
		VDVendorDetailsId = dr["VD_VendorDetailsId"] != DBNull.Value ? Convert.ToString(dr["VD_VendorDetailsId"]) : VDVendorDetailsId = null;
		VDVendorName = dr["VD_VendorName"] != DBNull.Value ? Convert.ToString(dr["VD_VendorName"]) : VDVendorName = null;
		VDReleaventShop = dr["VD_ReleaventShop"] != DBNull.Value ? Convert.ToString(dr["VD_ReleaventShop"]) : VDReleaventShop = null;
		VDContactNo = dr["VD_ContactNo"] != DBNull.Value ? Convert.ToString(dr["VD_ContactNo"]) : VDContactNo = null;
		VDAlternateNumber = dr["VD_AlternateNumber"] != DBNull.Value ? Convert.ToString(dr["VD_AlternateNumber"]) : VDAlternateNumber = null;
		VDAddressId = dr["VD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["VD_AddressId"]) : VDAddressId = null;
		VDShopImage = dr["VD_ShopImage"] != DBNull.Value ? Convert.ToString(dr["VD_ShopImage"]) : VDShopImage = null;
		VDShopMap = dr["VD_ShopMap"] != DBNull.Value ? Convert.ToString(dr["VD_ShopMap"]) : VDShopMap = null;
		VDVendorImage = dr["VD_VendorImage"] != DBNull.Value ? Convert.ToString(dr["VD_VendorImage"]) : VDVendorImage = null;
		VDVendorForPrePrimary = dr["VD_VendorForPrePrimary"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForPrePrimary"]) : VDVendorForPrePrimary = null;
		VDVendorForPrimary = dr["VD_VendorForPrimary"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForPrimary"]) : VDVendorForPrimary = null;
		VDVendorForHighSchool = dr["VD_VendorForHighSchool"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForHighSchool"]) : VDVendorForHighSchool = null;
		VDVendorForHouseUniform = dr["VD_VendorForHouseUniform"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForHouseUniform"]) : VDVendorForHouseUniform = null;
		VDVendorSchoolUniform = dr["VD_VendorSchoolUniform"] != DBNull.Value ? Convert.ToString(dr["VD_VendorSchoolUniform"]) : VDVendorSchoolUniform = null;
		VDVendorSchoolShoes = dr["VD_VendorSchoolShoes"] != DBNull.Value ? Convert.ToString(dr["VD_VendorSchoolShoes"]) : VDVendorSchoolShoes = null;
		VDVendorSchoolBooks = dr["VD_VendorSchoolBooks"] != DBNull.Value ? Convert.ToString(dr["VD_VendorSchoolBooks"]) : VDVendorSchoolBooks = null;
		VDVendorSchoolBags = dr["VD_VendorSchoolBags"] != DBNull.Value ? Convert.ToString(dr["VD_VendorSchoolBags"]) : VDVendorSchoolBags = null;
		VDVendorForBoys = dr["VD_VendorForBoys"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForBoys"]) : VDVendorForBoys = null;
		VDVendorForGirls = dr["VD_VendorForGirls"] != DBNull.Value ? Convert.ToString(dr["VD_VendorForGirls"]) : VDVendorForGirls = null;
		VDDate = dr["VD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["VD_Date"]) : VDDate = null;
		VDWebsite = dr["VD_Website"] != DBNull.Value ? Convert.ToString(dr["VD_Website"]) : VDWebsite = null;
		VDStatus = dr["VD_Status"] != DBNull.Value ? Convert.ToInt32(dr["VD_Status"]) : VDStatus = null;
	}
	
	public static TMSVendorDetails[] MapFrom(DataSet ds)
	{
		List<TMSVendorDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSVendorDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_VendorDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_VendorDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSVendorDetails instance = new TMSVendorDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorDetails Get(System.Int64 vdVendorId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSVendorDetails instance;
		
		
		instance = new TMSVendorDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdVendorId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSVendorDetails ID:" + vdVendorId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? vdVendorManagerId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdVendorManagerId, vdVendorName, vdReleaventShop, vdContactNo, vdAlternateNumber, vdAddressId, vdShopImage, vdShopMap, vdVendorImage, vdVendorForPrePrimary, vdVendorForPrimary, vdVendorForHighSchool, vdVendorForHouseUniform, vdVendorSchoolUniform, vdVendorSchoolShoes, vdVendorSchoolBooks, vdVendorSchoolBags, vdVendorForBoys, vdVendorForGirls, vdDate, vdWebsite, vdStatus);
		
		if (transaction == null)
		this.VDVendorId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.VDVendorId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? vdVendorManagerId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus)
	{
		Insert(vdVendorManagerId, vdVendorName, vdReleaventShop, vdContactNo, vdAlternateNumber, vdAddressId, vdShopImage, vdShopMap, vdVendorImage, vdVendorForPrePrimary, vdVendorForPrimary, vdVendorForHighSchool, vdVendorForHouseUniform, vdVendorSchoolUniform, vdVendorSchoolShoes, vdVendorSchoolBooks, vdVendorSchoolBags, vdVendorForBoys, vdVendorForGirls, vdDate, vdWebsite, vdStatus, null);
	}
	/// <summary>
	/// Insert current TMSVendorDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(VDVendorManagerId, VDVendorName, VDReleaventShop, VDContactNo, VDAlternateNumber, VDAddressId, VDShopImage, VDShopMap, VDVendorImage, VDVendorForPrePrimary, VDVendorForPrimary, VDVendorForHighSchool, VDVendorForHouseUniform, VDVendorSchoolUniform, VDVendorSchoolShoes, VDVendorSchoolBooks, VDVendorSchoolBags, VDVendorForBoys, VDVendorForGirls, VDDate, VDWebsite, VDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSVendorDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
    public static void Update(System.Int64? vdVendorId, System.Int64? vdVendorManagerId, System.String vdVendorDetailsId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorDetails_UPDATE";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        db.DiscoverParameters(dbCommand);
        dbCommand.Parameters["@vdVendorId"].Value = vdVendorId;
        dbCommand.Parameters["@vdVendorManagerId"].Value = vdVendorManagerId;
        //dbCommand.Parameters["@vdVendorDetailsId"].Value = vdVendorDetailsId;
        dbCommand.Parameters["@vdVendorName"].Value = vdVendorName;
        dbCommand.Parameters["@vdReleaventShop"].Value = vdReleaventShop;
        dbCommand.Parameters["@vdContactNo"].Value = vdContactNo;
        dbCommand.Parameters["@vdAlternateNumber"].Value = vdAlternateNumber;
        dbCommand.Parameters["@vdAddressId"].Value = vdAddressId;
        dbCommand.Parameters["@vdShopImage"].Value = vdShopImage;
        dbCommand.Parameters["@vdShopMap"].Value = vdShopMap;
        dbCommand.Parameters["@vdVendorImage"].Value = vdVendorImage;
        dbCommand.Parameters["@vdVendorForPrePrimary"].Value = vdVendorForPrePrimary;
        dbCommand.Parameters["@vdVendorForPrimary"].Value = vdVendorForPrimary;
        dbCommand.Parameters["@vdVendorForHighSchool"].Value = vdVendorForHighSchool;
        dbCommand.Parameters["@vdVendorForHouseUniform"].Value = vdVendorForHouseUniform;
        dbCommand.Parameters["@vdVendorSchoolUniform"].Value = vdVendorSchoolUniform;
        dbCommand.Parameters["@vdVendorSchoolShoes"].Value = vdVendorSchoolShoes;
        dbCommand.Parameters["@vdVendorSchoolBooks"].Value = vdVendorSchoolBooks;
        dbCommand.Parameters["@vdVendorSchoolBags"].Value = vdVendorSchoolBags;
        dbCommand.Parameters["@vdVendorForBoys"].Value = vdVendorForBoys;
        dbCommand.Parameters["@vdVendorForGirls"].Value = vdVendorForGirls;
        dbCommand.Parameters["@vdDate"].Value = vdDate;
        dbCommand.Parameters["@vdWebsite"].Value = vdWebsite;
        dbCommand.Parameters["@vdStatus"].Value = vdStatus;

		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
    public static void Update(System.Int64? vdVendorId, System.Int64? vdVendorManagerId, System.String vdVendorDetailsId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus)
	{
        Update(vdVendorId, vdVendorManagerId, vdVendorDetailsId, vdVendorName, vdReleaventShop, vdContactNo, vdAlternateNumber, vdAddressId, vdShopImage, vdShopMap, vdVendorImage, vdVendorForPrePrimary, vdVendorForPrimary, vdVendorForHighSchool, vdVendorForHouseUniform, vdVendorSchoolUniform, vdVendorSchoolShoes, vdVendorSchoolBooks, vdVendorSchoolBags, vdVendorForBoys, vdVendorForGirls, vdDate, vdWebsite, vdStatus, null);
	}
	
	public static void Update(TMSVendorDetails tMSVendorDetails)
	{
		tMSVendorDetails.Update();
	}
	
	public static void Update(TMSVendorDetails tMSVendorDetails, DbTransaction transaction)
	{
		tMSVendorDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@vdVendorId"].SourceColumn = "VD_VendorId";
		dbCommand.Parameters["@vdVendorManagerId"].SourceColumn = "VD_VendorManagerId";
		dbCommand.Parameters["@vdVendorName"].SourceColumn = "VD_VendorName";
		dbCommand.Parameters["@vdReleaventShop"].SourceColumn = "VD_ReleaventShop";
		dbCommand.Parameters["@vdContactNo"].SourceColumn = "VD_ContactNo";
		dbCommand.Parameters["@vdAlternateNumber"].SourceColumn = "VD_AlternateNumber";
		dbCommand.Parameters["@vdAddressId"].SourceColumn = "VD_AddressId";
		dbCommand.Parameters["@vdShopImage"].SourceColumn = "VD_ShopImage";
		dbCommand.Parameters["@vdShopMap"].SourceColumn = "VD_ShopMap";
		dbCommand.Parameters["@vdVendorImage"].SourceColumn = "VD_VendorImage";
		dbCommand.Parameters["@vdVendorForPrePrimary"].SourceColumn = "VD_VendorForPrePrimary";
		dbCommand.Parameters["@vdVendorForPrimary"].SourceColumn = "VD_VendorForPrimary";
		dbCommand.Parameters["@vdVendorForHighSchool"].SourceColumn = "VD_VendorForHighSchool";
		dbCommand.Parameters["@vdVendorForHouseUniform"].SourceColumn = "VD_VendorForHouseUniform";
		dbCommand.Parameters["@vdVendorSchoolUniform"].SourceColumn = "VD_VendorSchoolUniform";
		dbCommand.Parameters["@vdVendorSchoolShoes"].SourceColumn = "VD_VendorSchoolShoes";
		dbCommand.Parameters["@vdVendorSchoolBooks"].SourceColumn = "VD_VendorSchoolBooks";
		dbCommand.Parameters["@vdVendorSchoolBags"].SourceColumn = "VD_VendorSchoolBags";
		dbCommand.Parameters["@vdVendorForBoys"].SourceColumn = "VD_VendorForBoys";
		dbCommand.Parameters["@vdVendorForGirls"].SourceColumn = "VD_VendorForGirls";
		dbCommand.Parameters["@vdDate"].SourceColumn = "VD_Date";
		dbCommand.Parameters["@vdWebsite"].SourceColumn = "VD_Website";
		dbCommand.Parameters["@vdStatus"].SourceColumn = "VD_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? vdVendorId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdVendorId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? vdVendorId)
	{
		Delete(
		vdVendorId);
	}
	
	/// <summary>
	/// Delete current TMSVendorDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, VDVendorId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.VDVendorId = null;
	}
	
	/// <summary>
	/// Delete current TMSVendorDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVendorDetails[] Search(System.Int64? vdVendorId, System.Int64? vdVendorManagerId, System.String vdVendorDetailsId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVendorDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdVendorId, vdVendorManagerId, vdVendorDetailsId, vdVendorName, vdReleaventShop, vdContactNo, vdAlternateNumber, vdAddressId, vdShopImage, vdShopMap, vdVendorImage, vdVendorForPrePrimary, vdVendorForPrimary, vdVendorForHighSchool, vdVendorForHouseUniform, vdVendorSchoolUniform, vdVendorSchoolShoes, vdVendorSchoolBooks, vdVendorSchoolBags, vdVendorForBoys, vdVendorForGirls, vdDate, vdWebsite, vdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSVendorDetails.MapFrom(ds);
	}
	
	
	public static TMSVendorDetails[] Search(TMSVendorDetails searchObject)
	{
		return Search ( searchObject.VDVendorId, searchObject.VDVendorManagerId, searchObject.VDVendorDetailsId, searchObject.VDVendorName, searchObject.VDReleaventShop, searchObject.VDContactNo, searchObject.VDAlternateNumber, searchObject.VDAddressId, searchObject.VDShopImage, searchObject.VDShopMap, searchObject.VDVendorImage, searchObject.VDVendorForPrePrimary, searchObject.VDVendorForPrimary, searchObject.VDVendorForHighSchool, searchObject.VDVendorForHouseUniform, searchObject.VDVendorSchoolUniform, searchObject.VDVendorSchoolShoes, searchObject.VDVendorSchoolBooks, searchObject.VDVendorSchoolBags, searchObject.VDVendorForBoys, searchObject.VDVendorForGirls, searchObject.VDDate, searchObject.VDWebsite, searchObject.VDStatus);
	}
	
	/// <summary>
	/// Returns all TMSVendorDetails objects.
	/// </summary>
	/// <returns>List of all TMSVendorDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSVendorDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

