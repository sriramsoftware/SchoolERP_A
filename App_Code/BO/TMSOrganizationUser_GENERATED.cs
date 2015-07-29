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
public partial class TMSOrganizationUser
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_OrganizationUser]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ouOrganizationId;
	private System.Int64? _ouLoginId;
	private System.Int64? _ouDesignationId;
	private System.String _ouTitle;
	private System.String _ouFirstName;
	private System.String _ouMiddleName;
	private System.String _ouLastName;
	private System.DateTime? _ouRegistrationDate;
	private System.String _ouUserImage;
	private System.DateTime? _ouBirthDate;
	private System.Int32? _ouAge;
	private System.Int64? _ouAddressId;
	private System.Int32? _ouStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? OUOrganizationId
	{
		get
		{
			return _ouOrganizationId;
		}
		set
		{
			_ouOrganizationId = value;
		}
	}
	
	public System.Int64? OULoginId
	{
		get
		{
			return _ouLoginId;
		}
		set
		{
			_ouLoginId = value;
		}
	}
	
	public System.Int64? OUDesignationId
	{
		get
		{
			return _ouDesignationId;
		}
		set
		{
			_ouDesignationId = value;
		}
	}
	
	public System.String OUTitle
	{
		get
		{
			return _ouTitle;
		}
		set
		{
			_ouTitle = value;
		}
	}
	
	public System.String OUFirstName
	{
		get
		{
			return _ouFirstName;
		}
		set
		{
			_ouFirstName = value;
		}
	}
	
	public System.String OUMiddleName
	{
		get
		{
			return _ouMiddleName;
		}
		set
		{
			_ouMiddleName = value;
		}
	}
	
	public System.String OULastName
	{
		get
		{
			return _ouLastName;
		}
		set
		{
			_ouLastName = value;
		}
	}
	
	public System.DateTime? OURegistrationDate
	{
		get
		{
			return _ouRegistrationDate;
		}
		set
		{
			_ouRegistrationDate = value;
		}
	}
	
	public System.String OUUserImage
	{
		get
		{
			return _ouUserImage;
		}
		set
		{
			_ouUserImage = value;
		}
	}
	
	public System.DateTime? OUBirthDate
	{
		get
		{
			return _ouBirthDate;
		}
		set
		{
			_ouBirthDate = value;
		}
	}
	
	public System.Int32? OUAge
	{
		get
		{
			return _ouAge;
		}
		set
		{
			_ouAge = value;
		}
	}
	
	public System.Int64? OUAddressId
	{
		get
		{
			return _ouAddressId;
		}
		set
		{
			_ouAddressId = value;
		}
	}
	
	public System.Int32? OUStatus
	{
		get
		{
			return _ouStatus;
		}
		set
		{
			_ouStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("OU_OrganizationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_DesignationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_MiddleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_RegistrationDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_UserImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_BirthDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_Age", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_AddressId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("OU_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (OUOrganizationId == null)
		dr["OU_OrganizationId"] = DBNull.Value;
		else
		dr["OU_OrganizationId"] = OUOrganizationId;
		
		if (OULoginId == null)
		dr["OU_LoginId"] = DBNull.Value;
		else
		dr["OU_LoginId"] = OULoginId;
		
		if (OUDesignationId == null)
		dr["OU_DesignationId"] = DBNull.Value;
		else
		dr["OU_DesignationId"] = OUDesignationId;
		
		if (OUTitle == null)
		dr["OU_Title"] = DBNull.Value;
		else
		dr["OU_Title"] = OUTitle;
		
		if (OUFirstName == null)
		dr["OU_FirstName"] = DBNull.Value;
		else
		dr["OU_FirstName"] = OUFirstName;
		
		if (OUMiddleName == null)
		dr["OU_MiddleName"] = DBNull.Value;
		else
		dr["OU_MiddleName"] = OUMiddleName;
		
		if (OULastName == null)
		dr["OU_LastName"] = DBNull.Value;
		else
		dr["OU_LastName"] = OULastName;
		
		if (OURegistrationDate == null)
		dr["OU_RegistrationDate"] = DBNull.Value;
		else
		dr["OU_RegistrationDate"] = OURegistrationDate;
		
		if (OUUserImage == null)
		dr["OU_UserImage"] = DBNull.Value;
		else
		dr["OU_UserImage"] = OUUserImage;
		
		if (OUBirthDate == null)
		dr["OU_BirthDate"] = DBNull.Value;
		else
		dr["OU_BirthDate"] = OUBirthDate;
		
		if (OUAge == null)
		dr["OU_Age"] = DBNull.Value;
		else
		dr["OU_Age"] = OUAge;
		
		if (OUAddressId == null)
		dr["OU_AddressId"] = DBNull.Value;
		else
		dr["OU_AddressId"] = OUAddressId;
		
		if (OUStatus == null)
		dr["OU_Status"] = DBNull.Value;
		else
		dr["OU_Status"] = OUStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		OUOrganizationId = dr["OU_OrganizationId"] != DBNull.Value ? Convert.ToInt64(dr["OU_OrganizationId"]) : OUOrganizationId = null;
		OULoginId = dr["OU_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["OU_LoginId"]) : OULoginId = null;
		OUDesignationId = dr["OU_DesignationId"] != DBNull.Value ? Convert.ToInt64(dr["OU_DesignationId"]) : OUDesignationId = null;
		OUTitle = dr["OU_Title"] != DBNull.Value ? Convert.ToString(dr["OU_Title"]) : OUTitle = null;
		OUFirstName = dr["OU_FirstName"] != DBNull.Value ? Convert.ToString(dr["OU_FirstName"]) : OUFirstName = null;
		OUMiddleName = dr["OU_MiddleName"] != DBNull.Value ? Convert.ToString(dr["OU_MiddleName"]) : OUMiddleName = null;
		OULastName = dr["OU_LastName"] != DBNull.Value ? Convert.ToString(dr["OU_LastName"]) : OULastName = null;
		OURegistrationDate = dr["OU_RegistrationDate"] != DBNull.Value ? Convert.ToDateTime(dr["OU_RegistrationDate"]) : OURegistrationDate = null;
		OUUserImage = dr["OU_UserImage"] != DBNull.Value ? Convert.ToString(dr["OU_UserImage"]) : OUUserImage = null;
		OUBirthDate = dr["OU_BirthDate"] != DBNull.Value ? Convert.ToDateTime(dr["OU_BirthDate"]) : OUBirthDate = null;
		OUAge = dr["OU_Age"] != DBNull.Value ? Convert.ToInt32(dr["OU_Age"]) : OUAge = null;
		OUAddressId = dr["OU_AddressId"] != DBNull.Value ? Convert.ToInt64(dr["OU_AddressId"]) : OUAddressId = null;
		OUStatus = dr["OU_Status"] != DBNull.Value ? Convert.ToInt32(dr["OU_Status"]) : OUStatus = null;
	}
	
	public static TMSOrganizationUser[] MapFrom(DataSet ds)
	{
		List<TMSOrganizationUser> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSOrganizationUser>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_OrganizationUser] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_OrganizationUser] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSOrganizationUser instance = new TMSOrganizationUser();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOrganizationUser Get(System.Int64 ouOrganizationId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSOrganizationUser instance;
		
		
		instance = new TMSOrganizationUser();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ouOrganizationId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSOrganizationUser ID:" + ouOrganizationId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ouLoginId, System.Int64? ouDesignationId, System.String ouTitle, System.String ouFirstName, System.String ouMiddleName, System.String ouLastName, System.DateTime? ouRegistrationDate, System.String ouUserImage, System.DateTime? ouBirthDate, System.Int32? ouAge, System.Int64? ouAddressId, System.Int32? ouStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ouLoginId, ouDesignationId, ouTitle, ouFirstName, ouMiddleName, ouLastName, ouRegistrationDate, ouUserImage, ouBirthDate, ouAge, ouAddressId, ouStatus);
		
		if (transaction == null)
		this.OUOrganizationId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.OUOrganizationId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ouLoginId, System.Int64? ouDesignationId, System.String ouTitle, System.String ouFirstName, System.String ouMiddleName, System.String ouLastName, System.DateTime? ouRegistrationDate, System.String ouUserImage, System.DateTime? ouBirthDate, System.Int32? ouAge, System.Int64? ouAddressId, System.Int32? ouStatus)
	{
		Insert(ouLoginId, ouDesignationId, ouTitle, ouFirstName, ouMiddleName, ouLastName, ouRegistrationDate, ouUserImage, ouBirthDate, ouAge, ouAddressId, ouStatus, null);
	}
	/// <summary>
	/// Insert current TMSOrganizationUser to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(OULoginId, OUDesignationId, OUTitle, OUFirstName, OUMiddleName, OULastName, OURegistrationDate, OUUserImage, OUBirthDate, OUAge, OUAddressId, OUStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSOrganizationUser to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ouOrganizationId, System.Int64? ouLoginId, System.Int64? ouDesignationId, System.String ouTitle, System.String ouFirstName, System.String ouMiddleName, System.String ouLastName, System.DateTime? ouRegistrationDate, System.String ouUserImage, System.DateTime? ouBirthDate, System.Int32? ouAge, System.Int64? ouAddressId, System.Int32? ouStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ouOrganizationId"].Value = ouOrganizationId;
		dbCommand.Parameters["@ouLoginId"].Value = ouLoginId;
		dbCommand.Parameters["@ouDesignationId"].Value = ouDesignationId;
		dbCommand.Parameters["@ouTitle"].Value = ouTitle;
		dbCommand.Parameters["@ouFirstName"].Value = ouFirstName;
		dbCommand.Parameters["@ouMiddleName"].Value = ouMiddleName;
		dbCommand.Parameters["@ouLastName"].Value = ouLastName;
		dbCommand.Parameters["@ouRegistrationDate"].Value = ouRegistrationDate;
		dbCommand.Parameters["@ouUserImage"].Value = ouUserImage;
		dbCommand.Parameters["@ouBirthDate"].Value = ouBirthDate;
		dbCommand.Parameters["@ouAge"].Value = ouAge;
		dbCommand.Parameters["@ouAddressId"].Value = ouAddressId;
		dbCommand.Parameters["@ouStatus"].Value = ouStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ouOrganizationId, System.Int64? ouLoginId, System.Int64? ouDesignationId, System.String ouTitle, System.String ouFirstName, System.String ouMiddleName, System.String ouLastName, System.DateTime? ouRegistrationDate, System.String ouUserImage, System.DateTime? ouBirthDate, System.Int32? ouAge, System.Int64? ouAddressId, System.Int32? ouStatus)
	{
		Update(ouOrganizationId, ouLoginId, ouDesignationId, ouTitle, ouFirstName, ouMiddleName, ouLastName, ouRegistrationDate, ouUserImage, ouBirthDate, ouAge, ouAddressId, ouStatus, null);
	}
	
	public static void Update(TMSOrganizationUser tMSOrganizationUser)
	{
		tMSOrganizationUser.Update();
	}
	
	public static void Update(TMSOrganizationUser tMSOrganizationUser, DbTransaction transaction)
	{
		tMSOrganizationUser.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSOrganizationUser_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ouOrganizationId"].SourceColumn = "OU_OrganizationId";
		dbCommand.Parameters["@ouLoginId"].SourceColumn = "OU_LoginId";
		dbCommand.Parameters["@ouDesignationId"].SourceColumn = "OU_DesignationId";
		dbCommand.Parameters["@ouTitle"].SourceColumn = "OU_Title";
		dbCommand.Parameters["@ouFirstName"].SourceColumn = "OU_FirstName";
		dbCommand.Parameters["@ouMiddleName"].SourceColumn = "OU_MiddleName";
		dbCommand.Parameters["@ouLastName"].SourceColumn = "OU_LastName";
		dbCommand.Parameters["@ouRegistrationDate"].SourceColumn = "OU_RegistrationDate";
		dbCommand.Parameters["@ouUserImage"].SourceColumn = "OU_UserImage";
		dbCommand.Parameters["@ouBirthDate"].SourceColumn = "OU_BirthDate";
		dbCommand.Parameters["@ouAge"].SourceColumn = "OU_Age";
		dbCommand.Parameters["@ouAddressId"].SourceColumn = "OU_AddressId";
		dbCommand.Parameters["@ouStatus"].SourceColumn = "OU_Status";
		
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
	public static void Delete(System.Int64? ouOrganizationId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ouOrganizationId);
		
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
	public static void Delete(System.Int64? ouOrganizationId)
	{
		Delete(
		ouOrganizationId);
	}
	
	/// <summary>
	/// Delete current TMSOrganizationUser from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, OUOrganizationId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.OUOrganizationId = null;
	}
	
	/// <summary>
	/// Delete current TMSOrganizationUser from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSOrganizationUser[] Search(System.Int64? ouOrganizationId, System.Int64? ouLoginId, System.Int64? ouDesignationId, System.String ouTitle, System.String ouFirstName, System.String ouMiddleName, System.String ouLastName, System.DateTime? ouRegistrationDate, System.String ouUserImage, System.DateTime? ouBirthDate, System.Int32? ouAge, System.Int64? ouAddressId, System.Int32? ouStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSOrganizationUser_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ouOrganizationId, ouLoginId, ouDesignationId, ouTitle, ouFirstName, ouMiddleName, ouLastName, ouRegistrationDate, ouUserImage, ouBirthDate, ouAge, ouAddressId, ouStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSOrganizationUser.MapFrom(ds);
	}
	
	
	public static TMSOrganizationUser[] Search(TMSOrganizationUser searchObject)
	{
		return Search ( searchObject.OUOrganizationId, searchObject.OULoginId, searchObject.OUDesignationId, searchObject.OUTitle, searchObject.OUFirstName, searchObject.OUMiddleName, searchObject.OULastName, searchObject.OURegistrationDate, searchObject.OUUserImage, searchObject.OUBirthDate, searchObject.OUAge, searchObject.OUAddressId, searchObject.OUStatus);
	}
	
	/// <summary>
	/// Returns all TMSOrganizationUser objects.
	/// </summary>
	/// <returns>List of all TMSOrganizationUser objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSOrganizationUser[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

