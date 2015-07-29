/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/30/2012 3:00:32 PM                                    */
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
public partial class TMSExamTimeTable
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExamTimeTable]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ettExamId;
	private System.String _ettExamCode;
	private System.Int64? _ettFacultyLoginId;
	private System.String _ettExamType;
	private System.Int64? _ettExamTestId;
	private System.Int64? _ettSchoolId;
	private System.Int64? _ettSchoolSubId;
	private System.Int64? _ettSubjectId;
	private System.Int64? _ettDepartmentID;
	private System.String _ettExtra1;
	private System.DateTime? _ettExamDate;
	private System.String _ettStartTime;
	private System.String _ettEndTime;
	private System.Int64? _ettAddedById;
	private System.String _ettAddedType;
	private System.DateTime? _ettDate;
	private System.Int32? _ettStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ETTExamId
	{
		get
		{
			return _ettExamId;
		}
		set
		{
			_ettExamId = value;
		}
	}
	
	public System.String ETTExamCode
	{
		get
		{
			return _ettExamCode;
		}
		set
		{
			_ettExamCode = value;
		}
	}
	
	public System.Int64? ETTFacultyLoginId
	{
		get
		{
			return _ettFacultyLoginId;
		}
		set
		{
			_ettFacultyLoginId = value;
		}
	}
	
	public System.String ETTExamType
	{
		get
		{
			return _ettExamType;
		}
		set
		{
			_ettExamType = value;
		}
	}
	
	public System.Int64? ETTExamTestId
	{
		get
		{
			return _ettExamTestId;
		}
		set
		{
			_ettExamTestId = value;
		}
	}
	
	public System.Int64? ETTSchoolId
	{
		get
		{
			return _ettSchoolId;
		}
		set
		{
			_ettSchoolId = value;
		}
	}
	
	public System.Int64? ETTSchoolSubId
	{
		get
		{
			return _ettSchoolSubId;
		}
		set
		{
			_ettSchoolSubId = value;
		}
	}
	
	public System.Int64? ETTSubjectId
	{
		get
		{
			return _ettSubjectId;
		}
		set
		{
			_ettSubjectId = value;
		}
	}
	
	public System.Int64? ETTDepartmentID
	{
		get
		{
			return _ettDepartmentID;
		}
		set
		{
			_ettDepartmentID = value;
		}
	}
	
	public System.String ETTExtra1
	{
		get
		{
			return _ettExtra1;
		}
		set
		{
			_ettExtra1 = value;
		}
	}
	
	public System.DateTime? ETTExamDate
	{
		get
		{
			return _ettExamDate;
		}
		set
		{
			_ettExamDate = value;
		}
	}
	
	public System.String ETTStartTime
	{
		get
		{
			return _ettStartTime;
		}
		set
		{
			_ettStartTime = value;
		}
	}
	
	public System.String ETTEndTime
	{
		get
		{
			return _ettEndTime;
		}
		set
		{
			_ettEndTime = value;
		}
	}
	
	public System.Int64? ETTAddedById
	{
		get
		{
			return _ettAddedById;
		}
		set
		{
			_ettAddedById = value;
		}
	}
	
	public System.String ETTAddedType
	{
		get
		{
			return _ettAddedType;
		}
		set
		{
			_ettAddedType = value;
		}
	}
	
	public System.DateTime? ETTDate
	{
		get
		{
			return _ettDate;
		}
		set
		{
			_ettDate = value;
		}
	}
	
	public System.Int32? ETTStatus
	{
		get
		{
			return _ettStatus;
		}
		set
		{
			_ettStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ETT_ExamId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_ExamCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_ExamType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_ExamTestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_DepartmentID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_ExamDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_StartTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_EndTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_AddedType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ETT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ETTExamId == null)
		dr["ETT_ExamId"] = DBNull.Value;
		else
		dr["ETT_ExamId"] = ETTExamId;
		
		if (ETTExamCode == null)
		dr["ETT_ExamCode"] = DBNull.Value;
		else
		dr["ETT_ExamCode"] = ETTExamCode;
		
		if (ETTFacultyLoginId == null)
		dr["ETT_FacultyLoginId"] = DBNull.Value;
		else
		dr["ETT_FacultyLoginId"] = ETTFacultyLoginId;
		
		if (ETTExamType == null)
		dr["ETT_ExamType"] = DBNull.Value;
		else
		dr["ETT_ExamType"] = ETTExamType;
		
		if (ETTExamTestId == null)
		dr["ETT_ExamTestId"] = DBNull.Value;
		else
		dr["ETT_ExamTestId"] = ETTExamTestId;
		
		if (ETTSchoolId == null)
		dr["ETT_SchoolId"] = DBNull.Value;
		else
		dr["ETT_SchoolId"] = ETTSchoolId;
		
		if (ETTSchoolSubId == null)
		dr["ETT_SchoolSubId"] = DBNull.Value;
		else
		dr["ETT_SchoolSubId"] = ETTSchoolSubId;
		
		if (ETTSubjectId == null)
		dr["ETT_SubjectId"] = DBNull.Value;
		else
		dr["ETT_SubjectId"] = ETTSubjectId;
		
		if (ETTDepartmentID == null)
		dr["ETT_DepartmentID"] = DBNull.Value;
		else
		dr["ETT_DepartmentID"] = ETTDepartmentID;
		
		if (ETTExtra1 == null)
		dr["ETT_Extra1"] = DBNull.Value;
		else
		dr["ETT_Extra1"] = ETTExtra1;
		
		if (ETTExamDate == null)
		dr["ETT_ExamDate"] = DBNull.Value;
		else
		dr["ETT_ExamDate"] = ETTExamDate;
		
		if (ETTStartTime == null)
		dr["ETT_StartTime"] = DBNull.Value;
		else
		dr["ETT_StartTime"] = ETTStartTime;
		
		if (ETTEndTime == null)
		dr["ETT_EndTime"] = DBNull.Value;
		else
		dr["ETT_EndTime"] = ETTEndTime;
		
		if (ETTAddedById == null)
		dr["ETT_AddedById"] = DBNull.Value;
		else
		dr["ETT_AddedById"] = ETTAddedById;
		
		if (ETTAddedType == null)
		dr["ETT_AddedType"] = DBNull.Value;
		else
		dr["ETT_AddedType"] = ETTAddedType;
		
		if (ETTDate == null)
		dr["ETT_Date"] = DBNull.Value;
		else
		dr["ETT_Date"] = ETTDate;
		
		if (ETTStatus == null)
		dr["ETT_Status"] = DBNull.Value;
		else
		dr["ETT_Status"] = ETTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ETTExamId = dr["ETT_ExamId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_ExamId"]) : ETTExamId = null;
		ETTExamCode = dr["ETT_ExamCode"] != DBNull.Value ? Convert.ToString(dr["ETT_ExamCode"]) : ETTExamCode = null;
		ETTFacultyLoginId = dr["ETT_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_FacultyLoginId"]) : ETTFacultyLoginId = null;
		ETTExamType = dr["ETT_ExamType"] != DBNull.Value ? Convert.ToString(dr["ETT_ExamType"]) : ETTExamType = null;
		ETTExamTestId = dr["ETT_ExamTestId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_ExamTestId"]) : ETTExamTestId = null;
		ETTSchoolId = dr["ETT_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_SchoolId"]) : ETTSchoolId = null;
		ETTSchoolSubId = dr["ETT_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_SchoolSubId"]) : ETTSchoolSubId = null;
		ETTSubjectId = dr["ETT_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["ETT_SubjectId"]) : ETTSubjectId = null;
		ETTDepartmentID = dr["ETT_DepartmentID"] != DBNull.Value ? Convert.ToInt64(dr["ETT_DepartmentID"]) : ETTDepartmentID = null;
		ETTExtra1 = dr["ETT_Extra1"] != DBNull.Value ? Convert.ToString(dr["ETT_Extra1"]) : ETTExtra1 = null;
		ETTExamDate = dr["ETT_ExamDate"] != DBNull.Value ? Convert.ToDateTime(dr["ETT_ExamDate"]) : ETTExamDate = null;
		ETTStartTime = dr["ETT_StartTime"] != DBNull.Value ? Convert.ToString(dr["ETT_StartTime"]) : ETTStartTime = null;
		ETTEndTime = dr["ETT_EndTime"] != DBNull.Value ? Convert.ToString(dr["ETT_EndTime"]) : ETTEndTime = null;
		ETTAddedById = dr["ETT_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["ETT_AddedById"]) : ETTAddedById = null;
		ETTAddedType = dr["ETT_AddedType"] != DBNull.Value ? Convert.ToString(dr["ETT_AddedType"]) : ETTAddedType = null;
		ETTDate = dr["ETT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ETT_Date"]) : ETTDate = null;
		ETTStatus = dr["ETT_Status"] != DBNull.Value ? Convert.ToInt32(dr["ETT_Status"]) : ETTStatus = null;
	}
	
	public static TMSExamTimeTable[] MapFrom(DataSet ds)
	{
		List<TMSExamTimeTable> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExamTimeTable>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExamTimeTable] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExamTimeTable] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExamTimeTable instance = new TMSExamTimeTable();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamTimeTable Get(System.Int64 ettExamId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExamTimeTable instance;
		
		
		instance = new TMSExamTimeTable();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ettExamId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSExamTimeTable ID:" + ettExamId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ettExamCode, ettFacultyLoginId, ettExamType, ettExamTestId, ettSchoolId, ettSchoolSubId, ettSubjectId, ettDepartmentID, ettExtra1, ettExamDate, ettStartTime, ettEndTime, ettAddedById, ettAddedType, ettDate, ettStatus);
		
		if (transaction == null)
		this.ETTExamId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ETTExamId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus)
	{
		Insert(ettExamCode, ettFacultyLoginId, ettExamType, ettExamTestId, ettSchoolId, ettSchoolSubId, ettSubjectId, ettDepartmentID, ettExtra1, ettExamDate, ettStartTime, ettEndTime, ettAddedById, ettAddedType, ettDate, ettStatus, null);
	}
	/// <summary>
	/// Insert current TMSExamTimeTable to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ETTExamCode, ETTFacultyLoginId, ETTExamType, ETTExamTestId, ETTSchoolId, ETTSchoolSubId, ETTSubjectId, ETTDepartmentID, ETTExtra1, ETTExamDate, ETTStartTime, ETTEndTime, ETTAddedById, ETTAddedType, ETTDate, ETTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExamTimeTable to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ettExamId, System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ettExamId"].Value = ettExamId;
		dbCommand.Parameters["@ettExamCode"].Value = ettExamCode;
		dbCommand.Parameters["@ettFacultyLoginId"].Value = ettFacultyLoginId;
		dbCommand.Parameters["@ettExamType"].Value = ettExamType;
		dbCommand.Parameters["@ettExamTestId"].Value = ettExamTestId;
		dbCommand.Parameters["@ettSchoolId"].Value = ettSchoolId;
		dbCommand.Parameters["@ettSchoolSubId"].Value = ettSchoolSubId;
		dbCommand.Parameters["@ettSubjectId"].Value = ettSubjectId;
		dbCommand.Parameters["@ettDepartmentID"].Value = ettDepartmentID;
		dbCommand.Parameters["@ettExtra1"].Value = ettExtra1;
		dbCommand.Parameters["@ettExamDate"].Value = ettExamDate;
		dbCommand.Parameters["@ettStartTime"].Value = ettStartTime;
		dbCommand.Parameters["@ettEndTime"].Value = ettEndTime;
		dbCommand.Parameters["@ettAddedById"].Value = ettAddedById;
		dbCommand.Parameters["@ettAddedType"].Value = ettAddedType;
		dbCommand.Parameters["@ettDate"].Value = ettDate;
		dbCommand.Parameters["@ettStatus"].Value = ettStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ettExamId, System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus)
	{
		Update(ettExamId, ettExamCode, ettFacultyLoginId, ettExamType, ettExamTestId, ettSchoolId, ettSchoolSubId, ettSubjectId, ettDepartmentID, ettExtra1, ettExamDate, ettStartTime, ettEndTime, ettAddedById, ettAddedType, ettDate, ettStatus, null);
	}
	
	public static void Update(TMSExamTimeTable tMSExamTimeTable)
	{
		tMSExamTimeTable.Update();
	}
	
	public static void Update(TMSExamTimeTable tMSExamTimeTable, DbTransaction transaction)
	{
		tMSExamTimeTable.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExamTimeTable_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ettExamId"].SourceColumn = "ETT_ExamId";
		dbCommand.Parameters["@ettExamCode"].SourceColumn = "ETT_ExamCode";
		dbCommand.Parameters["@ettFacultyLoginId"].SourceColumn = "ETT_FacultyLoginId";
		dbCommand.Parameters["@ettExamType"].SourceColumn = "ETT_ExamType";
		dbCommand.Parameters["@ettExamTestId"].SourceColumn = "ETT_ExamTestId";
		dbCommand.Parameters["@ettSchoolId"].SourceColumn = "ETT_SchoolId";
		dbCommand.Parameters["@ettSchoolSubId"].SourceColumn = "ETT_SchoolSubId";
		dbCommand.Parameters["@ettSubjectId"].SourceColumn = "ETT_SubjectId";
		dbCommand.Parameters["@ettDepartmentID"].SourceColumn = "ETT_DepartmentID";
		dbCommand.Parameters["@ettExtra1"].SourceColumn = "ETT_Extra1";
		dbCommand.Parameters["@ettExamDate"].SourceColumn = "ETT_ExamDate";
		dbCommand.Parameters["@ettStartTime"].SourceColumn = "ETT_StartTime";
		dbCommand.Parameters["@ettEndTime"].SourceColumn = "ETT_EndTime";
		dbCommand.Parameters["@ettAddedById"].SourceColumn = "ETT_AddedById";
		dbCommand.Parameters["@ettAddedType"].SourceColumn = "ETT_AddedType";
		dbCommand.Parameters["@ettDate"].SourceColumn = "ETT_Date";
		dbCommand.Parameters["@ettStatus"].SourceColumn = "ETT_Status";
		
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
	public static void Delete(System.Int64? ettExamId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ettExamId);
		
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
	public static void Delete(System.Int64? ettExamId)
	{
		Delete(
		ettExamId);
	}
	
	/// <summary>
	/// Delete current TMSExamTimeTable from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ETTExamId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ETTExamId = null;
	}
	
	/// <summary>
	/// Delete current TMSExamTimeTable from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamTimeTable[] Search(System.Int64? ettExamId, System.String ettExamCode, System.Int64? ettFacultyLoginId, System.String ettExamType, System.Int64? ettExamTestId, System.Int64? ettSchoolId, System.Int64? ettSchoolSubId, System.Int64? ettSubjectId, System.Int64? ettDepartmentID, System.String ettExtra1, System.DateTime? ettExamDate, System.String ettStartTime, System.String ettEndTime, System.Int64? ettAddedById, System.String ettAddedType, System.DateTime? ettDate, System.Int32? ettStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamTimeTable_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ettExamId, ettExamCode, ettFacultyLoginId, ettExamType, ettExamTestId, ettSchoolId, ettSchoolSubId, ettSubjectId, ettDepartmentID, ettExtra1, ettExamDate, ettStartTime, ettEndTime, ettAddedById, ettAddedType, ettDate, ettStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExamTimeTable.MapFrom(ds);
	}
	
	
	public static TMSExamTimeTable[] Search(TMSExamTimeTable searchObject)
	{
		return Search ( searchObject.ETTExamId, searchObject.ETTExamCode, searchObject.ETTFacultyLoginId, searchObject.ETTExamType, searchObject.ETTExamTestId, searchObject.ETTSchoolId, searchObject.ETTSchoolSubId, searchObject.ETTSubjectId, searchObject.ETTDepartmentID, searchObject.ETTExtra1, searchObject.ETTExamDate, searchObject.ETTStartTime, searchObject.ETTEndTime, searchObject.ETTAddedById, searchObject.ETTAddedType, searchObject.ETTDate, searchObject.ETTStatus);
	}
	
	/// <summary>
	/// Returns all TMSExamTimeTable objects.
	/// </summary>
	/// <returns>List of all TMSExamTimeTable objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExamTimeTable[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

