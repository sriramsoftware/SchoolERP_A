/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSAddressDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AddressDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adAddressId;
	private System.String _adPermanentAddress;
	private System.String _adOfficeAddress;
	private System.String _adCommercialAddress;
	private System.String _adOptionalAddress;
	private System.String _adLandLineNo;
	private System.String _adOfficeNo;
	private System.String _adMobileNo;
	private System.String _adMobileOptionalNo;
	private System.String _adEmailId;
	private System.String _adPinCode;
	private System.String _adZipCode;
	private System.Int64? _adCountryId;
	private System.Int64? _adStateId;
	private System.Int64? _adCityId;
	private System.DateTime? _adAddressDate;
	private System.Int32? _adStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADAddressId
	{
		get
		{
			return _adAddressId;
		}
		set
		{
			_adAddressId = value;
		}
	}
	
	public System.String ADPermanentAddress
	{
		get
		{
			return _adPermanentAddress;
		}
		set
		{
			_adPermanentAddress = value;
		}
	}
	
	public System.String ADOfficeAddress
	{
		get
		{
			return _adOfficeAddress;
		}
		set
		{
			_adOfficeAddress = value;
		}
	}
	
	public System.String ADCommercialAddress
	{
		get
		{
			return _adCommercialAddress;
		}
		set
		{
			_adCommercialAddress = value;
		}
	}
	
	public System.String ADOptionalAddress
	{
		get
		{
			return _adOptionalAddress;
		}
		set
		{
			_adOptionalAddress = value;
		}
	}
	
	public System.String ADLandLineNo
	{
		get
		{
			return _adLandLineNo;
		}
		set
		{
			_adLandLineNo = value;
		}
	}
	
	public System.String ADOfficeNo
	{
		get
		{
			return _adOfficeNo;
		}
		set
		{
			_adOfficeNo = value;
		}
	}
	
	public System.String ADMobileNo
	{
		get
		{
			return _adMobileNo;
		}
		set
		{
			_adMobileNo = value;
		}
	}
	
	public System.String ADMobileOptionalNo
	{
		get
		{
			return _adMobileOptionalNo;
		}
		set
		{
			_adMobileOptionalNo = value;
		}
	}
	
	public System.String ADEmailId
	{
		get
		{
			return _adEmailId;
		}
		set
		{
			_adEmailId = value;
		}
	}
	
	public System.String ADPinCode
	{
		get
		{
			return _adPinCode;
		}
		set
		{
			_adPinCode = value;
		}
	}
	
	public System.String ADZipCode
	{
		get
		{
			return _adZipCode;
		}
		set
		{
			_adZipCode = value;
		}
	}
	
	public System.Int64? ADCountryId
	{
		get
		{
			return _adCountryId;
		}
		set
		{
			_adCountryId = value;
		}
	}
	
	public System.Int64? ADStateId
	{
		get
		{
			return _adStateId;
		}
		set
		{
			_adStateId = value;
		}
	}
	
	public System.Int64? ADCityId
	{
		get
		{
			return _adCityId;
		}
		set
		{
			_adCityId = value;
		}
	}
	
	public System.DateTime? ADAddressDate
	{
		get
		{
			return _adAddressDate;
		}
		set
		{
			_adAddressDate = value;
		}
	}
	
	public System.Int32? ADStatus
	{
		get
		{
			return _adStatus;
		}
		set
		{
			_adStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_PermanentAddress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_OfficeAddress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_CommercialAddress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_OptionalAddress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_LandLineNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_OfficeNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_MobileNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_MobileOptionalNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_PinCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ZipCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_CountryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_StateId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_CityId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_AddressDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADAddressId == null)
		dr["AD_AddressId"] = DBNull.Value;
		else
		dr["AD_AddressId"] = ADAddressId;
		
		if (ADPermanentAddress == null)
		dr["AD_PermanentAddress"] = DBNull.Value;
		else
		dr["AD_PermanentAddress"] = ADPermanentAddress;
		
		if (ADOfficeAddress == null)
		dr["AD_OfficeAddress"] = DBNull.Value;
		else
		dr["AD_OfficeAddress"] = ADOfficeAddress;
		
		if (ADCommercialAddress == null)
		dr["AD_CommercialAddress"] = DBNull.Value;
		else
		dr["AD_CommercialAddress"] = ADCommercialAddress;
		
		if (ADOptionalAddress == null)
		dr["AD_OptionalAddress"] = DBNull.Value;
		else
		dr["AD_OptionalAddress"] = ADOptionalAddress;
		
		if (ADLandLineNo == null)
		dr["AD_LandLineNo"] = DBNull.Value;
		else
		dr["AD_LandLineNo"] = ADLandLineNo;
		
		if (ADOfficeNo == null)
		dr["AD_OfficeNo"] = DBNull.Value;
		else
		dr["AD_OfficeNo"] = ADOfficeNo;
		
		if (ADMobileNo == null)
		dr["AD_MobileNo"] = DBNull.Value;
		else
		dr["AD_MobileNo"] = ADMobileNo;
		
		if (ADMobileOptionalNo == null)
		dr["AD_MobileOptionalNo"] = DBNull.Value;
		else
		dr["AD_MobileOptionalNo"] = ADMobileOptionalNo;
		
		if (ADEmailId == null)
		dr["AD_EmailId"] = DBNull.Value;
		else
		dr["AD_EmailId"] = ADEmailId;
		
		if (ADPinCode == null)
		dr["AD_PinCode"] = DBNull.Value;
		else
		dr["AD_PinCode"] = ADPinCode;
		
		if (ADZipCode == null)
		dr["AD_ZipCode"] = DBNull.Value;
		else
		dr["AD_ZipCode"] = ADZipCode;
		
		if (ADCountryId == null)
		dr["AD_CountryId"] = DBNull.Value;
		else
		dr["AD_CountryId"] = ADCountryId;
		
		if (ADStateId == null)
		dr["AD_StateId"] = DBNull.Value;
		else
		dr["AD_StateId"] = ADStateId;
		
		if (ADCityId == null)
		dr["AD_CityId"] = DBNull.Value;
		else
		dr["AD_CityId"] = ADCityId;
		
		if (ADAddressDate == null)
		dr["AD_AddressDate"] = DBNull.Value;
		else
		dr["AD_AddressDate"] = ADAddressDate;
		
		if (ADStatus == null)
		dr["AD_Status"] = DBNull.Value;
		else
		dr["AD_Status"] = ADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADAddressId = dr["AD_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["AD_AddressId"]) : ADAddressId = null;
		ADPermanentAddress = dr["AD_PermanentAddress"] != DBNull.Value ? Convert.ToString(dr["AD_PermanentAddress"]) : ADPermanentAddress = null;
		ADOfficeAddress = dr["AD_OfficeAddress"] != DBNull.Value ? Convert.ToString(dr["AD_OfficeAddress"]) : ADOfficeAddress = null;
		ADCommercialAddress = dr["AD_CommercialAddress"] != DBNull.Value ? Convert.ToString(dr["AD_CommercialAddress"]) : ADCommercialAddress = null;
		ADOptionalAddress = dr["AD_OptionalAddress"] != DBNull.Value ? Convert.ToString(dr["AD_OptionalAddress"]) : ADOptionalAddress = null;
		ADLandLineNo = dr["AD_LandLineNo"] != DBNull.Value ? Convert.ToString(dr["AD_LandLineNo"]) : ADLandLineNo = null;
		ADOfficeNo = dr["AD_OfficeNo"] != DBNull.Value ? Convert.ToString(dr["AD_OfficeNo"]) : ADOfficeNo = null;
		ADMobileNo = dr["AD_MobileNo"] != DBNull.Value ? Convert.ToString(dr["AD_MobileNo"]) : ADMobileNo = null;
		ADMobileOptionalNo = dr["AD_MobileOptionalNo"] != DBNull.Value ? Convert.ToString(dr["AD_MobileOptionalNo"]) : ADMobileOptionalNo = null;
		ADEmailId = dr["AD_EmailId"] != DBNull.Value ? Convert.ToString(dr["AD_EmailId"]) : ADEmailId = null;
		ADPinCode = dr["AD_PinCode"] != DBNull.Value ? Convert.ToString(dr["AD_PinCode"]) : ADPinCode = null;
		ADZipCode = dr["AD_ZipCode"] != DBNull.Value ? Convert.ToString(dr["AD_ZipCode"]) : ADZipCode = null;
		ADCountryId = dr["AD_CountryId"] != DBNull.Value ? Convert.ToInt64(dr["AD_CountryId"]) : ADCountryId = null;
		ADStateId = dr["AD_StateId"] != DBNull.Value ? Convert.ToInt64(dr["AD_StateId"]) : ADStateId = null;
		ADCityId = dr["AD_CityId"] != DBNull.Value ? Convert.ToInt64(dr["AD_CityId"]) : ADCityId = null;
		ADAddressDate = dr["AD_AddressDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_AddressDate"]) : ADAddressDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
	}
	
	public static TMSAddressDetails[] MapFrom(DataSet ds)
	{
		List<TMSAddressDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAddressDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AddressDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AddressDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAddressDetails instance = new TMSAddressDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAddressDetails Get(System.Int64 adAddressId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAddressDetails instance;
		
		
		instance = new TMSAddressDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAddressId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAddressDetails ID:" + adAddressId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus);
		
		if (transaction == null)
		this.ADAddressId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADAddressId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus)
	{
		Insert(adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus, null);
	}
	/// <summary>
	/// Insert current TMSAddressDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADPermanentAddress, ADOfficeAddress, ADCommercialAddress, ADOptionalAddress, ADLandLineNo, ADOfficeNo, ADMobileNo, ADMobileOptionalNo, ADEmailId, ADPinCode, ADZipCode, ADCountryId, ADStateId, ADCityId, ADAddressDate, ADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAddressDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adAddressId, System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAddressId"].Value = adAddressId;
		dbCommand.Parameters["@adPermanentAddress"].Value = adPermanentAddress;
		dbCommand.Parameters["@adOfficeAddress"].Value = adOfficeAddress;
		dbCommand.Parameters["@adCommercialAddress"].Value = adCommercialAddress;
		dbCommand.Parameters["@adOptionalAddress"].Value = adOptionalAddress;
		dbCommand.Parameters["@adLandLineNo"].Value = adLandLineNo;
		dbCommand.Parameters["@adOfficeNo"].Value = adOfficeNo;
		dbCommand.Parameters["@adMobileNo"].Value = adMobileNo;
		dbCommand.Parameters["@adMobileOptionalNo"].Value = adMobileOptionalNo;
		dbCommand.Parameters["@adEmailId"].Value = adEmailId;
		dbCommand.Parameters["@adPinCode"].Value = adPinCode;
		dbCommand.Parameters["@adZipCode"].Value = adZipCode;
		dbCommand.Parameters["@adCountryId"].Value = adCountryId;
		dbCommand.Parameters["@adStateId"].Value = adStateId;
		dbCommand.Parameters["@adCityId"].Value = adCityId;
		dbCommand.Parameters["@adAddressDate"].Value = adAddressDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adAddressId, System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus)
	{
		Update(adAddressId, adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus, null);
	}
	
	public static void Update(TMSAddressDetails tMSAddressDetails)
	{
		tMSAddressDetails.Update();
	}
	
	public static void Update(TMSAddressDetails tMSAddressDetails, DbTransaction transaction)
	{
		tMSAddressDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAddressDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adAddressId"].SourceColumn = "AD_AddressId";
		dbCommand.Parameters["@adPermanentAddress"].SourceColumn = "AD_PermanentAddress";
		dbCommand.Parameters["@adOfficeAddress"].SourceColumn = "AD_OfficeAddress";
		dbCommand.Parameters["@adCommercialAddress"].SourceColumn = "AD_CommercialAddress";
		dbCommand.Parameters["@adOptionalAddress"].SourceColumn = "AD_OptionalAddress";
		dbCommand.Parameters["@adLandLineNo"].SourceColumn = "AD_LandLineNo";
		dbCommand.Parameters["@adOfficeNo"].SourceColumn = "AD_OfficeNo";
		dbCommand.Parameters["@adMobileNo"].SourceColumn = "AD_MobileNo";
		dbCommand.Parameters["@adMobileOptionalNo"].SourceColumn = "AD_MobileOptionalNo";
		dbCommand.Parameters["@adEmailId"].SourceColumn = "AD_EmailId";
		dbCommand.Parameters["@adPinCode"].SourceColumn = "AD_PinCode";
		dbCommand.Parameters["@adZipCode"].SourceColumn = "AD_ZipCode";
		dbCommand.Parameters["@adCountryId"].SourceColumn = "AD_CountryId";
		dbCommand.Parameters["@adStateId"].SourceColumn = "AD_StateId";
		dbCommand.Parameters["@adCityId"].SourceColumn = "AD_CityId";
		dbCommand.Parameters["@adAddressDate"].SourceColumn = "AD_AddressDate";
		dbCommand.Parameters["@adStatus"].SourceColumn = "AD_Status";
		
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
	public static void Delete(System.Int64? adAddressId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAddressId);
		
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
	public static void Delete(System.Int64? adAddressId)
	{
		Delete(
		adAddressId);
	}
	
	/// <summary>
	/// Delete current TMSAddressDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADAddressId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADAddressId = null;
	}
	
	/// <summary>
	/// Delete current TMSAddressDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAddressDetails[] Search(System.Int64? adAddressId, System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAddressDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adAddressId, adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAddressDetails.MapFrom(ds);
	}
	
	
	public static TMSAddressDetails[] Search(TMSAddressDetails searchObject)
	{
		return Search ( searchObject.ADAddressId, searchObject.ADPermanentAddress, searchObject.ADOfficeAddress, searchObject.ADCommercialAddress, searchObject.ADOptionalAddress, searchObject.ADLandLineNo, searchObject.ADOfficeNo, searchObject.ADMobileNo, searchObject.ADMobileOptionalNo, searchObject.ADEmailId, searchObject.ADPinCode, searchObject.ADZipCode, searchObject.ADCountryId, searchObject.ADStateId, searchObject.ADCityId, searchObject.ADAddressDate, searchObject.ADStatus);
	}
	
	/// <summary>
	/// Returns all TMSAddressDetails objects.
	/// </summary>
	/// <returns>List of all TMSAddressDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAddressDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

