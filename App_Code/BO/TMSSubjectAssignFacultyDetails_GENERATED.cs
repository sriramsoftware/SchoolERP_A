/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 4:37:42 PM                                    */
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
public partial class TMSSubjectAssignFacultyDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SubjectAssignFacultyDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _safdAssignId;
	private System.Int64? _safdFacultyId;
	private System.Int64? _safdSubjectId;
	private System.Int64? _safdDepartmentId;
	private System.String _safdAssignType;
	private System.DateTime? _safdDate;
	private System.Int32? _safdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SAFDAssignId
	{
		get
		{
			return _safdAssignId;
		}
		set
		{
			_safdAssignId = value;
		}
	}
	
	public System.Int64? SAFDFacultyId
	{
		get
		{
			return _safdFacultyId;
		}
		set
		{
			_safdFacultyId = value;
		}
	}
	
	public System.Int64? SAFDSubjectId
	{
		get
		{
			return _safdSubjectId;
		}
		set
		{
			_safdSubjectId = value;
		}
	}
	
	public System.Int64? SAFDDepartmentId
	{
		get
		{
			return _safdDepartmentId;
		}
		set
		{
			_safdDepartmentId = value;
		}
	}
	
	public System.String SAFDAssignType
	{
		get
		{
			return _safdAssignType;
		}
		set
		{
			_safdAssignType = value;
		}
	}
	
	public System.DateTime? SAFDDate
	{
		get
		{
			return _safdDate;
		}
		set
		{
			_safdDate = value;
		}
	}
	
	public System.Int32? SAFDStatus
	{
		get
		{
			return _safdStatus;
		}
		set
		{
			_safdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_AssignId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_DepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_AssignType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SAFD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SAFDAssignId == null)
		dr["SAFD_AssignId"] = DBNull.Value;
		else
		dr["SAFD_AssignId"] = SAFDAssignId;
		
		if (SAFDFacultyId == null)
		dr["SAFD_FacultyId"] = DBNull.Value;
		else
		dr["SAFD_FacultyId"] = SAFDFacultyId;
		
		if (SAFDSubjectId == null)
		dr["SAFD_SubjectId"] = DBNull.Value;
		else
		dr["SAFD_SubjectId"] = SAFDSubjectId;
		
		if (SAFDDepartmentId == null)
		dr["SAFD_DepartmentId"] = DBNull.Value;
		else
		dr["SAFD_DepartmentId"] = SAFDDepartmentId;
		
		if (SAFDAssignType == null)
		dr["SAFD_AssignType"] = DBNull.Value;
		else
		dr["SAFD_AssignType"] = SAFDAssignType;
		
		if (SAFDDate == null)
		dr["SAFD_Date"] = DBNull.Value;
		else
		dr["SAFD_Date"] = SAFDDate;
		
		if (SAFDStatus == null)
		dr["SAFD_Status"] = DBNull.Value;
		else
		dr["SAFD_Status"] = SAFDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SAFDAssignId = dr["SAFD_AssignId"] != DBNull.Value ? Convert.ToInt64(dr["SAFD_AssignId"]) : SAFDAssignId = null;
		SAFDFacultyId = dr["SAFD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["SAFD_FacultyId"]) : SAFDFacultyId = null;
		SAFDSubjectId = dr["SAFD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SAFD_SubjectId"]) : SAFDSubjectId = null;
		SAFDDepartmentId = dr["SAFD_DepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["SAFD_DepartmentId"]) : SAFDDepartmentId = null;
		SAFDAssignType = dr["SAFD_AssignType"] != DBNull.Value ? Convert.ToString(dr["SAFD_AssignType"]) : SAFDAssignType = null;
		SAFDDate = dr["SAFD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SAFD_Date"]) : SAFDDate = null;
		SAFDStatus = dr["SAFD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SAFD_Status"]) : SAFDStatus = null;
	}
	
	public static TMSSubjectAssignFacultyDetails[] MapFrom(DataSet ds)
	{
		List<TMSSubjectAssignFacultyDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSubjectAssignFacultyDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SubjectAssignFacultyDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SubjectAssignFacultyDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSubjectAssignFacultyDetails instance = new TMSSubjectAssignFacultyDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectAssignFacultyDetails Get(System.Int64 safdAssignId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSubjectAssignFacultyDetails instance;
		
		
		instance = new TMSSubjectAssignFacultyDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, safdAssignId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSSubjectAssignFacultyDetails ID:" + safdAssignId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, safdFacultyId, safdSubjectId, safdDepartmentId, safdAssignType, safdDate, safdStatus);
		
		if (transaction == null)
		this.SAFDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SAFDAssignId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus)
	{
		Insert(safdFacultyId, safdSubjectId, safdDepartmentId, safdAssignType, safdDate, safdStatus, null);
	}
	/// <summary>
	/// Insert current TMSSubjectAssignFacultyDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SAFDFacultyId, SAFDSubjectId, SAFDDepartmentId, SAFDAssignType, SAFDDate, SAFDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSubjectAssignFacultyDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? safdAssignId, System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@safdAssignId"].Value = safdAssignId;
		dbCommand.Parameters["@safdFacultyId"].Value = safdFacultyId;
		dbCommand.Parameters["@safdSubjectId"].Value = safdSubjectId;
		dbCommand.Parameters["@safdDepartmentId"].Value = safdDepartmentId;
		dbCommand.Parameters["@safdAssignType"].Value = safdAssignType;
		dbCommand.Parameters["@safdDate"].Value = safdDate;
		dbCommand.Parameters["@safdStatus"].Value = safdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? safdAssignId, System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus)
	{
		Update(safdAssignId, safdFacultyId, safdSubjectId, safdDepartmentId, safdAssignType, safdDate, safdStatus, null);
	}
	
	public static void Update(TMSSubjectAssignFacultyDetails tMSSubjectAssignFacultyDetails)
	{
		tMSSubjectAssignFacultyDetails.Update();
	}
	
	public static void Update(TMSSubjectAssignFacultyDetails tMSSubjectAssignFacultyDetails, DbTransaction transaction)
	{
		tMSSubjectAssignFacultyDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@safdAssignId"].SourceColumn = "SAFD_AssignId";
		dbCommand.Parameters["@safdFacultyId"].SourceColumn = "SAFD_FacultyId";
		dbCommand.Parameters["@safdSubjectId"].SourceColumn = "SAFD_SubjectId";
		dbCommand.Parameters["@safdDepartmentId"].SourceColumn = "SAFD_DepartmentId";
		dbCommand.Parameters["@safdAssignType"].SourceColumn = "SAFD_AssignType";
		dbCommand.Parameters["@safdDate"].SourceColumn = "SAFD_Date";
		dbCommand.Parameters["@safdStatus"].SourceColumn = "SAFD_Status";
		
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
	public static void Delete(System.Int64? safdAssignId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, safdAssignId);
		
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
	public static void Delete(System.Int64? safdAssignId)
	{
		Delete(
		safdAssignId);
	}
	
	/// <summary>
	/// Delete current TMSSubjectAssignFacultyDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SAFDAssignId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SAFDAssignId = null;
	}
	
	/// <summary>
	/// Delete current TMSSubjectAssignFacultyDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectAssignFacultyDetails[] Search(System.Int64? safdAssignId, System.Int64? safdFacultyId, System.Int64? safdSubjectId, System.Int64? safdDepartmentId, System.String safdAssignType, System.DateTime? safdDate, System.Int32? safdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectAssignFacultyDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, safdAssignId, safdFacultyId, safdSubjectId, safdDepartmentId, safdAssignType, safdDate, safdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSubjectAssignFacultyDetails.MapFrom(ds);
	}
	
	
	public static TMSSubjectAssignFacultyDetails[] Search(TMSSubjectAssignFacultyDetails searchObject)
	{
		return Search ( searchObject.SAFDAssignId, searchObject.SAFDFacultyId, searchObject.SAFDSubjectId, searchObject.SAFDDepartmentId, searchObject.SAFDAssignType, searchObject.SAFDDate, searchObject.SAFDStatus);
	}
	
	/// <summary>
	/// Returns all TMSSubjectAssignFacultyDetails objects.
	/// </summary>
	/// <returns>List of all TMSSubjectAssignFacultyDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSubjectAssignFacultyDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

