/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/17/2012 5:57:36 PM                                    */
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
public partial class TMSSubjectAssignSchoolDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SubjectAssignSchoolDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sasdAssignId;
	private System.Int64? _sasdSchoolId;
	private System.Int64? _sasdSchoolSubId;
	private System.Int64? _sasdSubjectId;
	private System.Int64? _sasdDepartmentId;
	private System.String _sasdAssignType;
	private System.DateTime? _sasdDate;
	private System.Int32? _sasdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SASDAssignId
	{
		get
		{
			return _sasdAssignId;
		}
		set
		{
			_sasdAssignId = value;
		}
	}
	
	public System.Int64? SASDSchoolId
	{
		get
		{
			return _sasdSchoolId;
		}
		set
		{
			_sasdSchoolId = value;
		}
	}
	
	public System.Int64? SASDSchoolSubId
	{
		get
		{
			return _sasdSchoolSubId;
		}
		set
		{
			_sasdSchoolSubId = value;
		}
	}
	
	public System.Int64? SASDSubjectId
	{
		get
		{
			return _sasdSubjectId;
		}
		set
		{
			_sasdSubjectId = value;
		}
	}
	
	public System.Int64? SASDDepartmentId
	{
		get
		{
			return _sasdDepartmentId;
		}
		set
		{
			_sasdDepartmentId = value;
		}
	}
	
	public System.String SASDAssignType
	{
		get
		{
			return _sasdAssignType;
		}
		set
		{
			_sasdAssignType = value;
		}
	}
	
	public System.DateTime? SASDDate
	{
		get
		{
			return _sasdDate;
		}
		set
		{
			_sasdDate = value;
		}
	}
	
	public System.Int32? SASDStatus
	{
		get
		{
			return _sasdStatus;
		}
		set
		{
			_sasdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SASD_AssignId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_DepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_AssignType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SASD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SASDAssignId == null)
		dr["SASD_AssignId"] = DBNull.Value;
		else
		dr["SASD_AssignId"] = SASDAssignId;
		
		if (SASDSchoolId == null)
		dr["SASD_SchoolId"] = DBNull.Value;
		else
		dr["SASD_SchoolId"] = SASDSchoolId;
		
		if (SASDSchoolSubId == null)
		dr["SASD_SchoolSubId"] = DBNull.Value;
		else
		dr["SASD_SchoolSubId"] = SASDSchoolSubId;
		
		if (SASDSubjectId == null)
		dr["SASD_SubjectId"] = DBNull.Value;
		else
		dr["SASD_SubjectId"] = SASDSubjectId;
		
		if (SASDDepartmentId == null)
		dr["SASD_DepartmentId"] = DBNull.Value;
		else
		dr["SASD_DepartmentId"] = SASDDepartmentId;
		
		if (SASDAssignType == null)
		dr["SASD_AssignType"] = DBNull.Value;
		else
		dr["SASD_AssignType"] = SASDAssignType;
		
		if (SASDDate == null)
		dr["SASD_Date"] = DBNull.Value;
		else
		dr["SASD_Date"] = SASDDate;
		
		if (SASDStatus == null)
		dr["SASD_Status"] = DBNull.Value;
		else
		dr["SASD_Status"] = SASDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SASDAssignId = dr["SASD_AssignId"] != DBNull.Value ? Convert.ToInt64(dr["SASD_AssignId"]) : SASDAssignId = null;
		SASDSchoolId = dr["SASD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["SASD_SchoolId"]) : SASDSchoolId = null;
		SASDSchoolSubId = dr["SASD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["SASD_SchoolSubId"]) : SASDSchoolSubId = null;
		SASDSubjectId = dr["SASD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SASD_SubjectId"]) : SASDSubjectId = null;
		SASDDepartmentId = dr["SASD_DepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["SASD_DepartmentId"]) : SASDDepartmentId = null;
		SASDAssignType = dr["SASD_AssignType"] != DBNull.Value ? Convert.ToString(dr["SASD_AssignType"]) : SASDAssignType = null;
		SASDDate = dr["SASD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SASD_Date"]) : SASDDate = null;
		SASDStatus = dr["SASD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SASD_Status"]) : SASDStatus = null;
	}
	
	public static TMSSubjectAssignSchoolDetails[] MapFrom(DataSet ds)
	{
		List<TMSSubjectAssignSchoolDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSubjectAssignSchoolDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SubjectAssignSchoolDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SubjectAssignSchoolDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSubjectAssignSchoolDetails instance = new TMSSubjectAssignSchoolDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectAssignSchoolDetails Get(System.Int64 sasdAssignId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSubjectAssignSchoolDetails instance;
		
		
		instance = new TMSSubjectAssignSchoolDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sasdAssignId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSubjectAssignSchoolDetails ID:" + sasdAssignId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sasdSchoolId, sasdSchoolSubId, sasdSubjectId, sasdDepartmentId, sasdAssignType, sasdDate, sasdStatus);
		
		if (transaction == null)
		this.SASDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SASDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus)
	{
		Insert(sasdSchoolId, sasdSchoolSubId, sasdSubjectId, sasdDepartmentId, sasdAssignType, sasdDate, sasdStatus, null);
	}
	/// <summary>
	/// Insert current TMSSubjectAssignSchoolDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SASDSchoolId, SASDSchoolSubId, SASDSubjectId, SASDDepartmentId, SASDAssignType, SASDDate, SASDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSubjectAssignSchoolDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sasdAssignId, System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sasdAssignId"].Value = sasdAssignId;
		dbCommand.Parameters["@sasdSchoolId"].Value = sasdSchoolId;
		dbCommand.Parameters["@sasdSchoolSubId"].Value = sasdSchoolSubId;
		dbCommand.Parameters["@sasdSubjectId"].Value = sasdSubjectId;
		dbCommand.Parameters["@sasdDepartmentId"].Value = sasdDepartmentId;
		dbCommand.Parameters["@sasdAssignType"].Value = sasdAssignType;
		dbCommand.Parameters["@sasdDate"].Value = sasdDate;
		dbCommand.Parameters["@sasdStatus"].Value = sasdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sasdAssignId, System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus)
	{
		Update(sasdAssignId, sasdSchoolId, sasdSchoolSubId, sasdSubjectId, sasdDepartmentId, sasdAssignType, sasdDate, sasdStatus, null);
	}
	
	public static void Update(TMSSubjectAssignSchoolDetails tMSSubjectAssignSchoolDetails)
	{
		tMSSubjectAssignSchoolDetails.Update();
	}
	
	public static void Update(TMSSubjectAssignSchoolDetails tMSSubjectAssignSchoolDetails, DbTransaction transaction)
	{
		tMSSubjectAssignSchoolDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sasdAssignId"].SourceColumn = "SASD_AssignId";
		dbCommand.Parameters["@sasdSchoolId"].SourceColumn = "SASD_SchoolId";
		dbCommand.Parameters["@sasdSchoolSubId"].SourceColumn = "SASD_SchoolSubId";
		dbCommand.Parameters["@sasdSubjectId"].SourceColumn = "SASD_SubjectId";
		dbCommand.Parameters["@sasdDepartmentId"].SourceColumn = "SASD_DepartmentId";
		dbCommand.Parameters["@sasdAssignType"].SourceColumn = "SASD_AssignType";
		dbCommand.Parameters["@sasdDate"].SourceColumn = "SASD_Date";
		dbCommand.Parameters["@sasdStatus"].SourceColumn = "SASD_Status";
		
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
	public static void Delete(System.Int64? sasdAssignId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sasdAssignId);
		
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
	public static void Delete(System.Int64? sasdAssignId)
	{
		Delete(
		sasdAssignId);
	}
	
	/// <summary>
	/// Delete current TMSSubjectAssignSchoolDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SASDAssignId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SASDAssignId = null;
	}
	
	/// <summary>
	/// Delete current TMSSubjectAssignSchoolDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectAssignSchoolDetails[] Search(System.Int64? sasdAssignId, System.Int64? sasdSchoolId, System.Int64? sasdSchoolSubId, System.Int64? sasdSubjectId, System.Int64? sasdDepartmentId, System.String sasdAssignType, System.DateTime? sasdDate, System.Int32? sasdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignSchoolDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sasdAssignId, sasdSchoolId, sasdSchoolSubId, sasdSubjectId, sasdDepartmentId, sasdAssignType, sasdDate, sasdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSubjectAssignSchoolDetails.MapFrom(ds);
	}
	
	
	public static TMSSubjectAssignSchoolDetails[] Search(TMSSubjectAssignSchoolDetails searchObject)
	{
		return Search ( searchObject.SASDAssignId, searchObject.SASDSchoolId, searchObject.SASDSchoolSubId, searchObject.SASDSubjectId, searchObject.SASDDepartmentId, searchObject.SASDAssignType, searchObject.SASDDate, searchObject.SASDStatus);
	}
	
	/// <summary>
	/// Returns all TMSSubjectAssignSchoolDetails objects.
	/// </summary>
	/// <returns>List of all TMSSubjectAssignSchoolDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSubjectAssignSchoolDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

