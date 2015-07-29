/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/20/2012 5:04:46 PM                                    */
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
public partial class TMSPriviledgeUserDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_PriviledgeUserDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _pudUserId;
	private System.Int64? _pudUserLoginId;
	private System.String _pudUserLoginType;
	private System.String _pudTitle;
	private System.String _pudFirstName;
	private System.String _pudMiddleName;
	private System.String _pudLastName;
	private System.String _pudHighestDegreeCompletd;
	private System.String _pudEmailId;
	private System.String _pudMobileNo;
	private System.String _pudAddress;
	private System.Int64? _pudCountryId;
	private System.Int64? _pudStateId;
	private System.Int64? _pudCityId;
	private System.Int64? _pudAddedById;
	private System.String _pudAddedByType;
	private System.String _pudUserType;
	private System.DateTime? _pudDate;
	private System.Int32? _pudStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PUDUserId
	{
		get
		{
			return _pudUserId;
		}
		set
		{
			_pudUserId = value;
		}
	}
	
	public System.Int64? PUDUserLoginId
	{
		get
		{
			return _pudUserLoginId;
		}
		set
		{
			_pudUserLoginId = value;
		}
	}
	
	public System.String PUDUserLoginType
	{
		get
		{
			return _pudUserLoginType;
		}
		set
		{
			_pudUserLoginType = value;
		}
	}
	
	public System.String PUDTitle
	{
		get
		{
			return _pudTitle;
		}
		set
		{
			_pudTitle = value;
		}
	}
	
	public System.String PUDFirstName
	{
		get
		{
			return _pudFirstName;
		}
		set
		{
			_pudFirstName = value;
		}
	}
	
	public System.String PUDMiddleName
	{
		get
		{
			return _pudMiddleName;
		}
		set
		{
			_pudMiddleName = value;
		}
	}
	
	public System.String PUDLastName
	{
		get
		{
			return _pudLastName;
		}
		set
		{
			_pudLastName = value;
		}
	}
	
	public System.String PUDHighestDegreeCompletd
	{
		get
		{
			return _pudHighestDegreeCompletd;
		}
		set
		{
			_pudHighestDegreeCompletd = value;
		}
	}
	
	public System.String PUDEmailId
	{
		get
		{
			return _pudEmailId;
		}
		set
		{
			_pudEmailId = value;
		}
	}
	
	public System.String PUDMobileNo
	{
		get
		{
			return _pudMobileNo;
		}
		set
		{
			_pudMobileNo = value;
		}
	}
	
	public System.String PUDAddress
	{
		get
		{
			return _pudAddress;
		}
		set
		{
			_pudAddress = value;
		}
	}
	
	public System.Int64? PUDCountryId
	{
		get
		{
			return _pudCountryId;
		}
		set
		{
			_pudCountryId = value;
		}
	}
	
	public System.Int64? PUDStateId
	{
		get
		{
			return _pudStateId;
		}
		set
		{
			_pudStateId = value;
		}
	}
	
	public System.Int64? PUDCityId
	{
		get
		{
			return _pudCityId;
		}
		set
		{
			_pudCityId = value;
		}
	}
	
	public System.Int64? PUDAddedById
	{
		get
		{
			return _pudAddedById;
		}
		set
		{
			_pudAddedById = value;
		}
	}
	
	public System.String PUDAddedByType
	{
		get
		{
			return _pudAddedByType;
		}
		set
		{
			_pudAddedByType = value;
		}
	}
	
	public System.String PUDUserType
	{
		get
		{
			return _pudUserType;
		}
		set
		{
			_pudUserType = value;
		}
	}
	
	public System.DateTime? PUDDate
	{
		get
		{
			return _pudDate;
		}
		set
		{
			_pudDate = value;
		}
	}
	
	public System.Int32? PUDStatus
	{
		get
		{
			return _pudStatus;
		}
		set
		{
			_pudStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PUD_UserId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_UserLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_UserLoginType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_HighestDegreeCompletd", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_MobileNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_Address", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_CountryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_StateId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_CityId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_UserType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PUD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PUDUserId == null)
		dr["PUD_UserId"] = DBNull.Value;
		else
		dr["PUD_UserId"] = PUDUserId;
		
		if (PUDUserLoginId == null)
		dr["PUD_UserLoginId"] = DBNull.Value;
		else
		dr["PUD_UserLoginId"] = PUDUserLoginId;
		
		if (PUDUserLoginType == null)
		dr["PUD_UserLoginType"] = DBNull.Value;
		else
		dr["PUD_UserLoginType"] = PUDUserLoginType;
		
		if (PUDTitle == null)
		dr["PUD_Title"] = DBNull.Value;
		else
		dr["PUD_Title"] = PUDTitle;
		
		if (PUDFirstName == null)
		dr["PUD_FirstName"] = DBNull.Value;
		else
		dr["PUD_FirstName"] = PUDFirstName;
		
		if (PUDMiddleName == null)
		dr["PUD_MiddleName"] = DBNull.Value;
		else
		dr["PUD_MiddleName"] = PUDMiddleName;
		
		if (PUDLastName == null)
		dr["PUD_LastName"] = DBNull.Value;
		else
		dr["PUD_LastName"] = PUDLastName;
		
		if (PUDHighestDegreeCompletd == null)
		dr["PUD_HighestDegreeCompletd"] = DBNull.Value;
		else
		dr["PUD_HighestDegreeCompletd"] = PUDHighestDegreeCompletd;
		
		if (PUDEmailId == null)
		dr["PUD_EmailId"] = DBNull.Value;
		else
		dr["PUD_EmailId"] = PUDEmailId;
		
		if (PUDMobileNo == null)
		dr["PUD_MobileNo"] = DBNull.Value;
		else
		dr["PUD_MobileNo"] = PUDMobileNo;
		
		if (PUDAddress == null)
		dr["PUD_Address"] = DBNull.Value;
		else
		dr["PUD_Address"] = PUDAddress;
		
		if (PUDCountryId == null)
		dr["PUD_CountryId"] = DBNull.Value;
		else
		dr["PUD_CountryId"] = PUDCountryId;
		
		if (PUDStateId == null)
		dr["PUD_StateId"] = DBNull.Value;
		else
		dr["PUD_StateId"] = PUDStateId;
		
		if (PUDCityId == null)
		dr["PUD_CityId"] = DBNull.Value;
		else
		dr["PUD_CityId"] = PUDCityId;
		
		if (PUDAddedById == null)
		dr["PUD_AddedById"] = DBNull.Value;
		else
		dr["PUD_AddedById"] = PUDAddedById;
		
		if (PUDAddedByType == null)
		dr["PUD_AddedByType"] = DBNull.Value;
		else
		dr["PUD_AddedByType"] = PUDAddedByType;
		
		if (PUDUserType == null)
		dr["PUD_UserType"] = DBNull.Value;
		else
		dr["PUD_UserType"] = PUDUserType;
		
		if (PUDDate == null)
		dr["PUD_Date"] = DBNull.Value;
		else
		dr["PUD_Date"] = PUDDate;
		
		if (PUDStatus == null)
		dr["PUD_Status"] = DBNull.Value;
		else
		dr["PUD_Status"] = PUDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PUDUserId = dr["PUD_UserId"] != DBNull.Value ? Convert.ToInt64(dr["PUD_UserId"]) : PUDUserId = null;
		PUDUserLoginId = dr["PUD_UserLoginId"] != DBNull.Value ? Convert.ToInt64(dr["PUD_UserLoginId"]) : PUDUserLoginId = null;
		PUDUserLoginType = dr["PUD_UserLoginType"] != DBNull.Value ? Convert.ToString(dr["PUD_UserLoginType"]) : PUDUserLoginType = null;
		PUDTitle = dr["PUD_Title"] != DBNull.Value ? Convert.ToString(dr["PUD_Title"]) : PUDTitle = null;
		PUDFirstName = dr["PUD_FirstName"] != DBNull.Value ? Convert.ToString(dr["PUD_FirstName"]) : PUDFirstName = null;
		PUDMiddleName = dr["PUD_MiddleName"] != DBNull.Value ? Convert.ToString(dr["PUD_MiddleName"]) : PUDMiddleName = null;
		PUDLastName = dr["PUD_LastName"] != DBNull.Value ? Convert.ToString(dr["PUD_LastName"]) : PUDLastName = null;
		PUDHighestDegreeCompletd = dr["PUD_HighestDegreeCompletd"] != DBNull.Value ? Convert.ToString(dr["PUD_HighestDegreeCompletd"]) : PUDHighestDegreeCompletd = null;
		PUDEmailId = dr["PUD_EmailId"] != DBNull.Value ? Convert.ToString(dr["PUD_EmailId"]) : PUDEmailId = null;
		PUDMobileNo = dr["PUD_MobileNo"] != DBNull.Value ? Convert.ToString(dr["PUD_MobileNo"]) : PUDMobileNo = null;
		PUDAddress = dr["PUD_Address"] != DBNull.Value ? Convert.ToString(dr["PUD_Address"]) : PUDAddress = null;
		PUDCountryId = dr["PUD_CountryId"] != DBNull.Value ? Convert.ToInt64(dr["PUD_CountryId"]) : PUDCountryId = null;
		PUDStateId = dr["PUD_StateId"] != DBNull.Value ? Convert.ToInt64(dr["PUD_StateId"]) : PUDStateId = null;
		PUDCityId = dr["PUD_CityId"] != DBNull.Value ? Convert.ToInt64(dr["PUD_CityId"]) : PUDCityId = null;
		PUDAddedById = dr["PUD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["PUD_AddedById"]) : PUDAddedById = null;
		PUDAddedByType = dr["PUD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["PUD_AddedByType"]) : PUDAddedByType = null;
		PUDUserType = dr["PUD_UserType"] != DBNull.Value ? Convert.ToString(dr["PUD_UserType"]) : PUDUserType = null;
		PUDDate = dr["PUD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PUD_Date"]) : PUDDate = null;
		PUDStatus = dr["PUD_Status"] != DBNull.Value ? Convert.ToInt32(dr["PUD_Status"]) : PUDStatus = null;
	}
	
	public static TMSPriviledgeUserDetails[] MapFrom(DataSet ds)
	{
		List<TMSPriviledgeUserDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPriviledgeUserDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_PriviledgeUserDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_PriviledgeUserDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPriviledgeUserDetails instance = new TMSPriviledgeUserDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPriviledgeUserDetails Get(System.Int64 pudUserId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPriviledgeUserDetails instance;
		
		
		instance = new TMSPriviledgeUserDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pudUserId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0)// throw new ApplicationException("Could not get TMSPriviledgeUserDetails ID:" + pudUserId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pudUserLoginId, pudUserLoginType, pudTitle, pudFirstName, pudMiddleName, pudLastName, pudHighestDegreeCompletd, pudEmailId, pudMobileNo, pudAddress, pudCountryId, pudStateId, pudCityId, pudAddedById, pudAddedByType, pudUserType, pudDate, pudStatus);
		
		if (transaction == null)
		this.PUDUserId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PUDUserId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus)
	{
		Insert(pudUserLoginId, pudUserLoginType, pudTitle, pudFirstName, pudMiddleName, pudLastName, pudHighestDegreeCompletd, pudEmailId, pudMobileNo, pudAddress, pudCountryId, pudStateId, pudCityId, pudAddedById, pudAddedByType, pudUserType, pudDate, pudStatus, null);
	}
	/// <summary>
	/// Insert current TMSPriviledgeUserDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PUDUserLoginId, PUDUserLoginType, PUDTitle, PUDFirstName, PUDMiddleName, PUDLastName, PUDHighestDegreeCompletd, PUDEmailId, PUDMobileNo, PUDAddress, PUDCountryId, PUDStateId, PUDCityId, PUDAddedById, PUDAddedByType, PUDUserType, PUDDate, PUDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPriviledgeUserDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? pudUserId, System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@pudUserId"].Value = pudUserId;
		dbCommand.Parameters["@pudUserLoginId"].Value = pudUserLoginId;
		dbCommand.Parameters["@pudUserLoginType"].Value = pudUserLoginType;
		dbCommand.Parameters["@pudTitle"].Value = pudTitle;
		dbCommand.Parameters["@pudFirstName"].Value = pudFirstName;
		dbCommand.Parameters["@pudMiddleName"].Value = pudMiddleName;
		dbCommand.Parameters["@pudLastName"].Value = pudLastName;
		dbCommand.Parameters["@pudHighestDegreeCompletd"].Value = pudHighestDegreeCompletd;
		dbCommand.Parameters["@pudEmailId"].Value = pudEmailId;
		dbCommand.Parameters["@pudMobileNo"].Value = pudMobileNo;
		dbCommand.Parameters["@pudAddress"].Value = pudAddress;
		dbCommand.Parameters["@pudCountryId"].Value = pudCountryId;
		dbCommand.Parameters["@pudStateId"].Value = pudStateId;
		dbCommand.Parameters["@pudCityId"].Value = pudCityId;
		dbCommand.Parameters["@pudAddedById"].Value = pudAddedById;
		dbCommand.Parameters["@pudAddedByType"].Value = pudAddedByType;
		dbCommand.Parameters["@pudUserType"].Value = pudUserType;
		dbCommand.Parameters["@pudDate"].Value = pudDate;
		dbCommand.Parameters["@pudStatus"].Value = pudStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? pudUserId, System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus)
	{
		Update(pudUserId, pudUserLoginId, pudUserLoginType, pudTitle, pudFirstName, pudMiddleName, pudLastName, pudHighestDegreeCompletd, pudEmailId, pudMobileNo, pudAddress, pudCountryId, pudStateId, pudCityId, pudAddedById, pudAddedByType, pudUserType, pudDate, pudStatus, null);
	}
	
	public static void Update(TMSPriviledgeUserDetails tMSPriviledgeUserDetails)
	{
		tMSPriviledgeUserDetails.Update();
	}
	
	public static void Update(TMSPriviledgeUserDetails tMSPriviledgeUserDetails, DbTransaction transaction)
	{
		tMSPriviledgeUserDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@pudUserId"].SourceColumn = "PUD_UserId";
		dbCommand.Parameters["@pudUserLoginId"].SourceColumn = "PUD_UserLoginId";
		dbCommand.Parameters["@pudUserLoginType"].SourceColumn = "PUD_UserLoginType";
		dbCommand.Parameters["@pudTitle"].SourceColumn = "PUD_Title";
		dbCommand.Parameters["@pudFirstName"].SourceColumn = "PUD_FirstName";
		dbCommand.Parameters["@pudMiddleName"].SourceColumn = "PUD_MiddleName";
		dbCommand.Parameters["@pudLastName"].SourceColumn = "PUD_LastName";
		dbCommand.Parameters["@pudHighestDegreeCompletd"].SourceColumn = "PUD_HighestDegreeCompletd";
		dbCommand.Parameters["@pudEmailId"].SourceColumn = "PUD_EmailId";
		dbCommand.Parameters["@pudMobileNo"].SourceColumn = "PUD_MobileNo";
		dbCommand.Parameters["@pudAddress"].SourceColumn = "PUD_Address";
		dbCommand.Parameters["@pudCountryId"].SourceColumn = "PUD_CountryId";
		dbCommand.Parameters["@pudStateId"].SourceColumn = "PUD_StateId";
		dbCommand.Parameters["@pudCityId"].SourceColumn = "PUD_CityId";
		dbCommand.Parameters["@pudAddedById"].SourceColumn = "PUD_AddedById";
		dbCommand.Parameters["@pudAddedByType"].SourceColumn = "PUD_AddedByType";
		dbCommand.Parameters["@pudUserType"].SourceColumn = "PUD_UserType";
		dbCommand.Parameters["@pudDate"].SourceColumn = "PUD_Date";
		dbCommand.Parameters["@pudStatus"].SourceColumn = "PUD_Status";
		
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
	public static void Delete(System.Int64? pudUserId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pudUserId);
		
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
	public static void Delete(System.Int64? pudUserId)
	{
		Delete(
		pudUserId);
	}
	
	/// <summary>
	/// Delete current TMSPriviledgeUserDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PUDUserId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PUDUserId = null;
	}
	
	/// <summary>
	/// Delete current TMSPriviledgeUserDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPriviledgeUserDetails[] Search(System.Int64? pudUserId, System.Int64? pudUserLoginId, System.String pudUserLoginType, System.String pudTitle, System.String pudFirstName, System.String pudMiddleName, System.String pudLastName, System.String pudHighestDegreeCompletd, System.String pudEmailId, System.String pudMobileNo, System.String pudAddress, System.Int64? pudCountryId, System.Int64? pudStateId, System.Int64? pudCityId, System.Int64? pudAddedById, System.String pudAddedByType, System.String pudUserType, System.DateTime? pudDate, System.Int32? pudStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPriviledgeUserDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, pudUserId, pudUserLoginId, pudUserLoginType, pudTitle, pudFirstName, pudMiddleName, pudLastName, pudHighestDegreeCompletd, pudEmailId, pudMobileNo, pudAddress, pudCountryId, pudStateId, pudCityId, pudAddedById, pudAddedByType, pudUserType, pudDate, pudStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPriviledgeUserDetails.MapFrom(ds);
	}
	
	
	public static TMSPriviledgeUserDetails[] Search(TMSPriviledgeUserDetails searchObject)
	{
		return Search ( searchObject.PUDUserId, searchObject.PUDUserLoginId, searchObject.PUDUserLoginType, searchObject.PUDTitle, searchObject.PUDFirstName, searchObject.PUDMiddleName, searchObject.PUDLastName, searchObject.PUDHighestDegreeCompletd, searchObject.PUDEmailId, searchObject.PUDMobileNo, searchObject.PUDAddress, searchObject.PUDCountryId, searchObject.PUDStateId, searchObject.PUDCityId, searchObject.PUDAddedById, searchObject.PUDAddedByType, searchObject.PUDUserType, searchObject.PUDDate, searchObject.PUDStatus);
	}
	
	/// <summary>
	/// Returns all TMSPriviledgeUserDetails objects.
	/// </summary>
	/// <returns>List of all TMSPriviledgeUserDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPriviledgeUserDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

