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
public partial class TMSAdministrativeOrgUser
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdministrativeOrgUser]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _aouOrganizationId;
	private System.Int64? _aouLoginId;
	private System.Int64? _aouDesignationId;
	private System.String _aouTitle;
	private System.String _aouFirstName;
	private System.String _aouMiddleName;
	private System.String _aouLastName;
	private System.DateTime? _aouRegistrationDate;
	private System.String _aouUserImage;
	private System.DateTime? _aouBirthDate;
	private System.Int32? _aouAge;
	private System.Int64? _aouAddressId;
	private System.Int32? _aouStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? AOUOrganizationId
	{
		get
		{
			return _aouOrganizationId;
		}
		set
		{
			_aouOrganizationId = value;
		}
	}
	
	public System.Int64? AOULoginId
	{
		get
		{
			return _aouLoginId;
		}
		set
		{
			_aouLoginId = value;
		}
	}
	
	public System.Int64? AOUDesignationId
	{
		get
		{
			return _aouDesignationId;
		}
		set
		{
			_aouDesignationId = value;
		}
	}
	
	public System.String AOUTitle
	{
		get
		{
			return _aouTitle;
		}
		set
		{
			_aouTitle = value;
		}
	}
	
	public System.String AOUFirstName
	{
		get
		{
			return _aouFirstName;
		}
		set
		{
			_aouFirstName = value;
		}
	}
	
	public System.String AOUMiddleName
	{
		get
		{
			return _aouMiddleName;
		}
		set
		{
			_aouMiddleName = value;
		}
	}
	
	public System.String AOULastName
	{
		get
		{
			return _aouLastName;
		}
		set
		{
			_aouLastName = value;
		}
	}
	
	public System.DateTime? AOURegistrationDate
	{
		get
		{
			return _aouRegistrationDate;
		}
		set
		{
			_aouRegistrationDate = value;
		}
	}
	
	public System.String AOUUserImage
	{
		get
		{
			return _aouUserImage;
		}
		set
		{
			_aouUserImage = value;
		}
	}
	
	public System.DateTime? AOUBirthDate
	{
		get
		{
			return _aouBirthDate;
		}
		set
		{
			_aouBirthDate = value;
		}
	}
	
	public System.Int32? AOUAge
	{
		get
		{
			return _aouAge;
		}
		set
		{
			_aouAge = value;
		}
	}
	
	public System.Int64? AOUAddressId
	{
		get
		{
			return _aouAddressId;
		}
		set
		{
			_aouAddressId = value;
		}
	}
	
	public System.Int32? AOUStatus
	{
		get
		{
			return _aouStatus;
		}
		set
		{
			_aouStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AOU_OrganizationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_DesignationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_RegistrationDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_UserImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_BirthDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_Age", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AOU_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (AOUOrganizationId == null)
		dr["AOU_OrganizationId"] = DBNull.Value;
		else
		dr["AOU_OrganizationId"] = AOUOrganizationId;
		
		if (AOULoginId == null)
		dr["AOU_LoginId"] = DBNull.Value;
		else
		dr["AOU_LoginId"] = AOULoginId;
		
		if (AOUDesignationId == null)
		dr["AOU_DesignationId"] = DBNull.Value;
		else
		dr["AOU_DesignationId"] = AOUDesignationId;
		
		if (AOUTitle == null)
		dr["AOU_Title"] = DBNull.Value;
		else
		dr["AOU_Title"] = AOUTitle;
		
		if (AOUFirstName == null)
		dr["AOU_FirstName"] = DBNull.Value;
		else
		dr["AOU_FirstName"] = AOUFirstName;
		
		if (AOUMiddleName == null)
		dr["AOU_MiddleName"] = DBNull.Value;
		else
		dr["AOU_MiddleName"] = AOUMiddleName;
		
		if (AOULastName == null)
		dr["AOU_LastName"] = DBNull.Value;
		else
		dr["AOU_LastName"] = AOULastName;
		
		if (AOURegistrationDate == null)
		dr["AOU_RegistrationDate"] = DBNull.Value;
		else
		dr["AOU_RegistrationDate"] = AOURegistrationDate;
		
		if (AOUUserImage == null)
		dr["AOU_UserImage"] = DBNull.Value;
		else
		dr["AOU_UserImage"] = AOUUserImage;
		
		if (AOUBirthDate == null)
		dr["AOU_BirthDate"] = DBNull.Value;
		else
		dr["AOU_BirthDate"] = AOUBirthDate;
		
		if (AOUAge == null)
		dr["AOU_Age"] = DBNull.Value;
		else
		dr["AOU_Age"] = AOUAge;
		
		if (AOUAddressId == null)
		dr["AOU_AddressId"] = DBNull.Value;
		else
		dr["AOU_AddressId"] = AOUAddressId;
		
		if (AOUStatus == null)
		dr["AOU_Status"] = DBNull.Value;
		else
		dr["AOU_Status"] = AOUStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		AOUOrganizationId = dr["AOU_OrganizationId"] != DBNull.Value ? Convert.ToInt64(dr["AOU_OrganizationId"]) : AOUOrganizationId = null;
		AOULoginId = dr["AOU_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["AOU_LoginId"]) : AOULoginId = null;
		AOUDesignationId = dr["AOU_DesignationId"] != DBNull.Value ? Convert.ToInt64(dr["AOU_DesignationId"]) : AOUDesignationId = null;
		AOUTitle = dr["AOU_Title"] != DBNull.Value ? Convert.ToString(dr["AOU_Title"]) : AOUTitle = null;
		AOUFirstName = dr["AOU_FirstName"] != DBNull.Value ? Convert.ToString(dr["AOU_FirstName"]) : AOUFirstName = null;
		AOUMiddleName = dr["AOU_MiddleName"] != DBNull.Value ? Convert.ToString(dr["AOU_MiddleName"]) : AOUMiddleName = null;
		AOULastName = dr["AOU_LastName"] != DBNull.Value ? Convert.ToString(dr["AOU_LastName"]) : AOULastName = null;
		AOURegistrationDate = dr["AOU_RegistrationDate"] != DBNull.Value ? Convert.ToDateTime(dr["AOU_RegistrationDate"]) : AOURegistrationDate = null;
		AOUUserImage = dr["AOU_UserImage"] != DBNull.Value ? Convert.ToString(dr["AOU_UserImage"]) : AOUUserImage = null;
		AOUBirthDate = dr["AOU_BirthDate"] != DBNull.Value ? Convert.ToDateTime(dr["AOU_BirthDate"]) : AOUBirthDate = null;
		AOUAge = dr["AOU_Age"] != DBNull.Value ? Convert.ToInt32(dr["AOU_Age"]) : AOUAge = null;
		AOUAddressId = dr["AOU_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["AOU_AddressId"]) : AOUAddressId = null;
		AOUStatus = dr["AOU_Status"] != DBNull.Value ? Convert.ToInt32(dr["AOU_Status"]) : AOUStatus = null;
	}
	
	public static TMSAdministrativeOrgUser[] MapFrom(DataSet ds)
	{
		List<TMSAdministrativeOrgUser> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdministrativeOrgUser>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdministrativeOrgUser] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdministrativeOrgUser] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdministrativeOrgUser instance = new TMSAdministrativeOrgUser();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdministrativeOrgUser Get(System.Int64 aouOrganizationId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdministrativeOrgUser instance;
		
		
		instance = new TMSAdministrativeOrgUser();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aouOrganizationId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAdministrativeOrgUser ID:" + aouOrganizationId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? aouLoginId, System.Int64? aouDesignationId, System.String aouTitle, System.String aouFirstName, System.String aouMiddleName, System.String aouLastName, System.DateTime? aouRegistrationDate, System.String aouUserImage, System.DateTime? aouBirthDate, System.Int32? aouAge, System.Int64? aouAddressId, System.Int32? aouStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aouLoginId, aouDesignationId, aouTitle, aouFirstName, aouMiddleName, aouLastName, aouRegistrationDate, aouUserImage, aouBirthDate, aouAge, aouAddressId, aouStatus);
		
		if (transaction == null)
		this.AOUOrganizationId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.AOUOrganizationId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? aouLoginId, System.Int64? aouDesignationId, System.String aouTitle, System.String aouFirstName, System.String aouMiddleName, System.String aouLastName, System.DateTime? aouRegistrationDate, System.String aouUserImage, System.DateTime? aouBirthDate, System.Int32? aouAge, System.Int64? aouAddressId, System.Int32? aouStatus)
	{
		Insert(aouLoginId, aouDesignationId, aouTitle, aouFirstName, aouMiddleName, aouLastName, aouRegistrationDate, aouUserImage, aouBirthDate, aouAge, aouAddressId, aouStatus, null);
	}
	/// <summary>
	/// Insert current TMSAdministrativeOrgUser to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(AOULoginId, AOUDesignationId, AOUTitle, AOUFirstName, AOUMiddleName, AOULastName, AOURegistrationDate, AOUUserImage, AOUBirthDate, AOUAge, AOUAddressId, AOUStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdministrativeOrgUser to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? aouOrganizationId, System.Int64? aouLoginId, System.Int64? aouDesignationId, System.String aouTitle, System.String aouFirstName, System.String aouMiddleName, System.String aouLastName, System.DateTime? aouRegistrationDate, System.String aouUserImage, System.DateTime? aouBirthDate, System.Int32? aouAge, System.Int64? aouAddressId, System.Int32? aouStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@aouOrganizationId"].Value = aouOrganizationId;
		dbCommand.Parameters["@aouLoginId"].Value = aouLoginId;
		dbCommand.Parameters["@aouDesignationId"].Value = aouDesignationId;
		dbCommand.Parameters["@aouTitle"].Value = aouTitle;
		dbCommand.Parameters["@aouFirstName"].Value = aouFirstName;
		dbCommand.Parameters["@aouMiddleName"].Value = aouMiddleName;
		dbCommand.Parameters["@aouLastName"].Value = aouLastName;
		dbCommand.Parameters["@aouRegistrationDate"].Value = aouRegistrationDate;
		dbCommand.Parameters["@aouUserImage"].Value = aouUserImage;
		dbCommand.Parameters["@aouBirthDate"].Value = aouBirthDate;
		dbCommand.Parameters["@aouAge"].Value = aouAge;
		dbCommand.Parameters["@aouAddressId"].Value = aouAddressId;
		dbCommand.Parameters["@aouStatus"].Value = aouStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? aouOrganizationId, System.Int64? aouLoginId, System.Int64? aouDesignationId, System.String aouTitle, System.String aouFirstName, System.String aouMiddleName, System.String aouLastName, System.DateTime? aouRegistrationDate, System.String aouUserImage, System.DateTime? aouBirthDate, System.Int32? aouAge, System.Int64? aouAddressId, System.Int32? aouStatus)
	{
		Update(aouOrganizationId, aouLoginId, aouDesignationId, aouTitle, aouFirstName, aouMiddleName, aouLastName, aouRegistrationDate, aouUserImage, aouBirthDate, aouAge, aouAddressId, aouStatus, null);
	}
	
	public static void Update(TMSAdministrativeOrgUser tMSAdministrativeOrgUser)
	{
		tMSAdministrativeOrgUser.Update();
	}
	
	public static void Update(TMSAdministrativeOrgUser tMSAdministrativeOrgUser, DbTransaction transaction)
	{
		tMSAdministrativeOrgUser.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@aouOrganizationId"].SourceColumn = "AOU_OrganizationId";
		dbCommand.Parameters["@aouLoginId"].SourceColumn = "AOU_LoginId";
		dbCommand.Parameters["@aouDesignationId"].SourceColumn = "AOU_DesignationId";
		dbCommand.Parameters["@aouTitle"].SourceColumn = "AOU_Title";
		dbCommand.Parameters["@aouFirstName"].SourceColumn = "AOU_FirstName";
		dbCommand.Parameters["@aouMiddleName"].SourceColumn = "AOU_MiddleName";
		dbCommand.Parameters["@aouLastName"].SourceColumn = "AOU_LastName";
		dbCommand.Parameters["@aouRegistrationDate"].SourceColumn = "AOU_RegistrationDate";
		dbCommand.Parameters["@aouUserImage"].SourceColumn = "AOU_UserImage";
		dbCommand.Parameters["@aouBirthDate"].SourceColumn = "AOU_BirthDate";
		dbCommand.Parameters["@aouAge"].SourceColumn = "AOU_Age";
		dbCommand.Parameters["@aouAddressId"].SourceColumn = "AOU_AddressId";
		dbCommand.Parameters["@aouStatus"].SourceColumn = "AOU_Status";
		
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
	public static void Delete(System.Int64? aouOrganizationId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aouOrganizationId);
		
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
	public static void Delete(System.Int64? aouOrganizationId)
	{
		Delete(
		aouOrganizationId);
	}
	
	/// <summary>
	/// Delete current TMSAdministrativeOrgUser from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, AOUOrganizationId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.AOUOrganizationId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdministrativeOrgUser from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdministrativeOrgUser[] Search(System.Int64? aouOrganizationId, System.Int64? aouLoginId, System.Int64? aouDesignationId, System.String aouTitle, System.String aouFirstName, System.String aouMiddleName, System.String aouLastName, System.DateTime? aouRegistrationDate, System.String aouUserImage, System.DateTime? aouBirthDate, System.Int32? aouAge, System.Int64? aouAddressId, System.Int32? aouStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdministrativeOrgUser_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, aouOrganizationId, aouLoginId, aouDesignationId, aouTitle, aouFirstName, aouMiddleName, aouLastName, aouRegistrationDate, aouUserImage, aouBirthDate, aouAge, aouAddressId, aouStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdministrativeOrgUser.MapFrom(ds);
	}
	
	
	public static TMSAdministrativeOrgUser[] Search(TMSAdministrativeOrgUser searchObject)
	{
		return Search ( searchObject.AOUOrganizationId, searchObject.AOULoginId, searchObject.AOUDesignationId, searchObject.AOUTitle, searchObject.AOUFirstName, searchObject.AOUMiddleName, searchObject.AOULastName, searchObject.AOURegistrationDate, searchObject.AOUUserImage, searchObject.AOUBirthDate, searchObject.AOUAge, searchObject.AOUAddressId, searchObject.AOUStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdministrativeOrgUser objects.
	/// </summary>
	/// <returns>List of all TMSAdministrativeOrgUser objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdministrativeOrgUser[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

