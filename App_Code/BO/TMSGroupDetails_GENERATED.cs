/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/21/2012 12:21:51 PM                                    */
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
public partial class TMSGroupDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_GroupDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _gdGroupId;
	private System.Int64? _gdSchoolID;
	private System.String _gdGroupName;
	private System.String _gdGroupDescription;
	private System.String _gdGroupTeacherId;
	private System.DateTime? _gdDate;
	private System.Int32? _gdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? GDGroupId
	{
		get
		{
			return _gdGroupId;
		}
		set
		{
			_gdGroupId = value;
		}
	}
	
	public System.Int64? GDSchoolID
	{
		get
		{
			return _gdSchoolID;
		}
		set
		{
			_gdSchoolID = value;
		}
	}
	
	public System.String GDGroupName
	{
		get
		{
			return _gdGroupName;
		}
		set
		{
			_gdGroupName = value;
		}
	}
	
	public System.String GDGroupDescription
	{
		get
		{
			return _gdGroupDescription;
		}
		set
		{
			_gdGroupDescription = value;
		}
	}
	
	public System.String GDGroupTeacherId
	{
		get
		{
			return _gdGroupTeacherId;
		}
		set
		{
			_gdGroupTeacherId = value;
		}
	}
	
	public System.DateTime? GDDate
	{
		get
		{
			return _gdDate;
		}
		set
		{
			_gdDate = value;
		}
	}
	
	public System.Int32? GDStatus
	{
		get
		{
			return _gdStatus;
		}
		set
		{
			_gdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("GD_GroupId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_SchoolID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_GroupName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_GroupDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_GroupTeacherId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (GDGroupId == null)
		dr["GD_GroupId"] = DBNull.Value;
		else
		dr["GD_GroupId"] = GDGroupId;
		
		if (GDSchoolID == null)
		dr["GD_SchoolID"] = DBNull.Value;
		else
		dr["GD_SchoolID"] = GDSchoolID;
		
		if (GDGroupName == null)
		dr["GD_GroupName"] = DBNull.Value;
		else
		dr["GD_GroupName"] = GDGroupName;
		
		if (GDGroupDescription == null)
		dr["GD_GroupDescription"] = DBNull.Value;
		else
		dr["GD_GroupDescription"] = GDGroupDescription;
		
		if (GDGroupTeacherId == null)
		dr["GD_GroupTeacherId"] = DBNull.Value;
		else
		dr["GD_GroupTeacherId"] = GDGroupTeacherId;
		
		if (GDDate == null)
		dr["GD_Date"] = DBNull.Value;
		else
		dr["GD_Date"] = GDDate;
		
		if (GDStatus == null)
		dr["GD_Status"] = DBNull.Value;
		else
		dr["GD_Status"] = GDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		GDGroupId = dr["GD_GroupId"] != DBNull.Value ? Convert.ToInt64(dr["GD_GroupId"]) : GDGroupId = null;
		GDSchoolID = dr["GD_SchoolID"] != DBNull.Value ? Convert.ToInt64(dr["GD_SchoolID"]) : GDSchoolID = null;
		GDGroupName = dr["GD_GroupName"] != DBNull.Value ? Convert.ToString(dr["GD_GroupName"]) : GDGroupName = null;
		GDGroupDescription = dr["GD_GroupDescription"] != DBNull.Value ? Convert.ToString(dr["GD_GroupDescription"]) : GDGroupDescription = null;
		GDGroupTeacherId = dr["GD_GroupTeacherId"] != DBNull.Value ? Convert.ToString(dr["GD_GroupTeacherId"]) : GDGroupTeacherId = null;
		GDDate = dr["GD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["GD_Date"]) : GDDate = null;
		GDStatus = dr["GD_Status"] != DBNull.Value ? Convert.ToInt32(dr["GD_Status"]) : GDStatus = null;
	}
	
	public static TMSGroupDetails[] MapFrom(DataSet ds)
	{
		List<TMSGroupDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSGroupDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_GroupDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_GroupDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSGroupDetails instance = new TMSGroupDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGroupDetails Get(System.Int64 gdGroupId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSGroupDetails instance;
		
		
		instance = new TMSGroupDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGroupId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) 
            //throw new ApplicationException("Could not get TMSGroupDetails ID:" + gdGroupId.ToString()+ " from Database.");
	 return  null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdSchoolID, gdGroupName, gdGroupDescription, gdGroupTeacherId, gdDate, gdStatus);
		
		if (transaction == null)
		this.GDGroupId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.GDGroupId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus)
	{
		Insert(gdSchoolID, gdGroupName, gdGroupDescription, gdGroupTeacherId, gdDate, gdStatus, null);
	}
	/// <summary>
	/// Insert current TMSGroupDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(GDSchoolID, GDGroupName, GDGroupDescription, GDGroupTeacherId, GDDate, GDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSGroupDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? gdGroupId, System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gdGroupId"].Value = gdGroupId;
		dbCommand.Parameters["@gdSchoolID"].Value = gdSchoolID;
		dbCommand.Parameters["@gdGroupName"].Value = gdGroupName;
		dbCommand.Parameters["@gdGroupDescription"].Value = gdGroupDescription;
		dbCommand.Parameters["@gdGroupTeacherId"].Value = gdGroupTeacherId;
		dbCommand.Parameters["@gdDate"].Value = gdDate;
		dbCommand.Parameters["@gdStatus"].Value = gdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? gdGroupId, System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus)
	{
		Update(gdGroupId, gdSchoolID, gdGroupName, gdGroupDescription, gdGroupTeacherId, gdDate, gdStatus, null);
	}
	
	public static void Update(TMSGroupDetails tMSGroupDetails)
	{
		tMSGroupDetails.Update();
	}
	
	public static void Update(TMSGroupDetails tMSGroupDetails, DbTransaction transaction)
	{
		tMSGroupDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSGroupDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gdGroupId"].SourceColumn = "GD_GroupId";
		dbCommand.Parameters["@gdSchoolID"].SourceColumn = "GD_SchoolID";
		dbCommand.Parameters["@gdGroupName"].SourceColumn = "GD_GroupName";
		dbCommand.Parameters["@gdGroupDescription"].SourceColumn = "GD_GroupDescription";
		dbCommand.Parameters["@gdGroupTeacherId"].SourceColumn = "GD_GroupTeacherId";
		dbCommand.Parameters["@gdDate"].SourceColumn = "GD_Date";
		dbCommand.Parameters["@gdStatus"].SourceColumn = "GD_Status";
		
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
	public static void Delete(System.Int64? gdGroupId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGroupId);
		
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
	public static void Delete(System.Int64? gdGroupId)
	{
		Delete(
		gdGroupId);
	}
	
	/// <summary>
	/// Delete current TMSGroupDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, GDGroupId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.GDGroupId = null;
	}
	
	/// <summary>
	/// Delete current TMSGroupDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGroupDetails[] Search(System.Int64? gdGroupId, System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGroupId, gdSchoolID, gdGroupName, gdGroupDescription, gdGroupTeacherId, gdDate, gdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSGroupDetails.MapFrom(ds);
	}
	
	
	public static TMSGroupDetails[] Search(TMSGroupDetails searchObject)
	{
		return Search ( searchObject.GDGroupId, searchObject.GDSchoolID, searchObject.GDGroupName, searchObject.GDGroupDescription, searchObject.GDGroupTeacherId, searchObject.GDDate, searchObject.GDStatus);
	}
	
	/// <summary>
	/// Returns all TMSGroupDetails objects.
	/// </summary>
	/// <returns>List of all TMSGroupDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSGroupDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

