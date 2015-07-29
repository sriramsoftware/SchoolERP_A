/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/27/2012 1:01:57 PM                                    */
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
public partial class TMSClassMonitorDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ClassMonitorDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cmdMonitorId;
	private System.Int64? _cmdStudentId;
	private System.Int64? _cmdFacultyId;
	private System.Int64? _cmdSchoolId;
	private System.Int64? _cmdSchoolSubId;
	private System.String _cmdMonthName;
	private System.String _cmdYear;
	private System.String _cmdMonitorType;
	private System.DateTime? _cmdDate;
	private System.Int32? _cmdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CMDMonitorId
	{
		get
		{
			return _cmdMonitorId;
		}
		set
		{
			_cmdMonitorId = value;
		}
	}
	
	public System.Int64? CMDStudentId
	{
		get
		{
			return _cmdStudentId;
		}
		set
		{
			_cmdStudentId = value;
		}
	}
	
	public System.Int64? CMDFacultyId
	{
		get
		{
			return _cmdFacultyId;
		}
		set
		{
			_cmdFacultyId = value;
		}
	}
	
	public System.Int64? CMDSchoolId
	{
		get
		{
			return _cmdSchoolId;
		}
		set
		{
			_cmdSchoolId = value;
		}
	}
	
	public System.Int64? CMDSchoolSubId
	{
		get
		{
			return _cmdSchoolSubId;
		}
		set
		{
			_cmdSchoolSubId = value;
		}
	}
	
	public System.String CMDMonthName
	{
		get
		{
			return _cmdMonthName;
		}
		set
		{
			_cmdMonthName = value;
		}
	}
	
	public System.String CMDYear
	{
		get
		{
			return _cmdYear;
		}
		set
		{
			_cmdYear = value;
		}
	}
	
	public System.String CMDMonitorType
	{
		get
		{
			return _cmdMonitorType;
		}
		set
		{
			_cmdMonitorType = value;
		}
	}
	
	public System.DateTime? CMDDate
	{
		get
		{
			return _cmdDate;
		}
		set
		{
			_cmdDate = value;
		}
	}
	
	public System.Int32? CMDStatus
	{
		get
		{
			return _cmdStatus;
		}
		set
		{
			_cmdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CMD_MonitorId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_MonthName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_MonitorType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CMD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CMDMonitorId == null)
		dr["CMD_MonitorId"] = DBNull.Value;
		else
		dr["CMD_MonitorId"] = CMDMonitorId;
		
		if (CMDStudentId == null)
		dr["CMD_StudentId"] = DBNull.Value;
		else
		dr["CMD_StudentId"] = CMDStudentId;
		
		if (CMDFacultyId == null)
		dr["CMD_FacultyId"] = DBNull.Value;
		else
		dr["CMD_FacultyId"] = CMDFacultyId;
		
		if (CMDSchoolId == null)
		dr["CMD_SchoolId"] = DBNull.Value;
		else
		dr["CMD_SchoolId"] = CMDSchoolId;
		
		if (CMDSchoolSubId == null)
		dr["CMD_SchoolSubId"] = DBNull.Value;
		else
		dr["CMD_SchoolSubId"] = CMDSchoolSubId;
		
		if (CMDMonthName == null)
		dr["CMD_MonthName"] = DBNull.Value;
		else
		dr["CMD_MonthName"] = CMDMonthName;
		
		if (CMDYear == null)
		dr["CMD_Year"] = DBNull.Value;
		else
		dr["CMD_Year"] = CMDYear;
		
		if (CMDMonitorType == null)
		dr["CMD_MonitorType"] = DBNull.Value;
		else
		dr["CMD_MonitorType"] = CMDMonitorType;
		
		if (CMDDate == null)
		dr["CMD_Date"] = DBNull.Value;
		else
		dr["CMD_Date"] = CMDDate;
		
		if (CMDStatus == null)
		dr["CMD_Status"] = DBNull.Value;
		else
		dr["CMD_Status"] = CMDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CMDMonitorId = dr["CMD_MonitorId"] != DBNull.Value ? Convert.ToInt64(dr["CMD_MonitorId"]) : CMDMonitorId = null;
		CMDStudentId = dr["CMD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["CMD_StudentId"]) : CMDStudentId = null;
		CMDFacultyId = dr["CMD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["CMD_FacultyId"]) : CMDFacultyId = null;
		CMDSchoolId = dr["CMD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["CMD_SchoolId"]) : CMDSchoolId = null;
		CMDSchoolSubId = dr["CMD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["CMD_SchoolSubId"]) : CMDSchoolSubId = null;
		CMDMonthName = dr["CMD_MonthName"] != DBNull.Value ? Convert.ToString(dr["CMD_MonthName"]) : CMDMonthName = null;
		CMDYear = dr["CMD_Year"] != DBNull.Value ? Convert.ToString(dr["CMD_Year"]) : CMDYear = null;
		CMDMonitorType = dr["CMD_MonitorType"] != DBNull.Value ? Convert.ToString(dr["CMD_MonitorType"]) : CMDMonitorType = null;
		CMDDate = dr["CMD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CMD_Date"]) : CMDDate = null;
		CMDStatus = dr["CMD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CMD_Status"]) : CMDStatus = null;
	}
	
	public static TMSClassMonitorDetails[] MapFrom(DataSet ds)
	{
		List<TMSClassMonitorDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSClassMonitorDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ClassMonitorDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ClassMonitorDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSClassMonitorDetails instance = new TMSClassMonitorDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassMonitorDetails Get(System.Int64 cmdMonitorId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSClassMonitorDetails instance;
		
		
		instance = new TMSClassMonitorDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cmdMonitorId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSClassMonitorDetails ID:" + cmdMonitorId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cmdStudentId, cmdFacultyId, cmdSchoolId, cmdSchoolSubId, cmdMonthName, cmdYear, cmdMonitorType, cmdDate, cmdStatus);
		
		if (transaction == null)
		this.CMDMonitorId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CMDMonitorId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus)
	{
		Insert(cmdStudentId, cmdFacultyId, cmdSchoolId, cmdSchoolSubId, cmdMonthName, cmdYear, cmdMonitorType, cmdDate, cmdStatus, null);
	}
	/// <summary>
	/// Insert current TMSClassMonitorDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CMDStudentId, CMDFacultyId, CMDSchoolId, CMDSchoolSubId, CMDMonthName, CMDYear, CMDMonitorType, CMDDate, CMDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSClassMonitorDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cmdMonitorId, System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cmdMonitorId"].Value = cmdMonitorId;
		dbCommand.Parameters["@cmdStudentId"].Value = cmdStudentId;
		dbCommand.Parameters["@cmdFacultyId"].Value = cmdFacultyId;
		dbCommand.Parameters["@cmdSchoolId"].Value = cmdSchoolId;
		dbCommand.Parameters["@cmdSchoolSubId"].Value = cmdSchoolSubId;
		dbCommand.Parameters["@cmdMonthName"].Value = cmdMonthName;
		dbCommand.Parameters["@cmdYear"].Value = cmdYear;
		dbCommand.Parameters["@cmdMonitorType"].Value = cmdMonitorType;
		dbCommand.Parameters["@cmdDate"].Value = cmdDate;
		dbCommand.Parameters["@cmdStatus"].Value = cmdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cmdMonitorId, System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus)
	{
		Update(cmdMonitorId, cmdStudentId, cmdFacultyId, cmdSchoolId, cmdSchoolSubId, cmdMonthName, cmdYear, cmdMonitorType, cmdDate, cmdStatus, null);
	}
	
	public static void Update(TMSClassMonitorDetails tMSClassMonitorDetails)
	{
		tMSClassMonitorDetails.Update();
	}
	
	public static void Update(TMSClassMonitorDetails tMSClassMonitorDetails, DbTransaction transaction)
	{
		tMSClassMonitorDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cmdMonitorId"].SourceColumn = "CMD_MonitorId";
		dbCommand.Parameters["@cmdStudentId"].SourceColumn = "CMD_StudentId";
		dbCommand.Parameters["@cmdFacultyId"].SourceColumn = "CMD_FacultyId";
		dbCommand.Parameters["@cmdSchoolId"].SourceColumn = "CMD_SchoolId";
		dbCommand.Parameters["@cmdSchoolSubId"].SourceColumn = "CMD_SchoolSubId";
		dbCommand.Parameters["@cmdMonthName"].SourceColumn = "CMD_MonthName";
		dbCommand.Parameters["@cmdYear"].SourceColumn = "CMD_Year";
		dbCommand.Parameters["@cmdMonitorType"].SourceColumn = "CMD_MonitorType";
		dbCommand.Parameters["@cmdDate"].SourceColumn = "CMD_Date";
		dbCommand.Parameters["@cmdStatus"].SourceColumn = "CMD_Status";
		
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
	public static void Delete(System.Int64? cmdMonitorId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cmdMonitorId);
		
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
	public static void Delete(System.Int64? cmdMonitorId)
	{
		Delete(
		cmdMonitorId);
	}
	
	/// <summary>
	/// Delete current TMSClassMonitorDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CMDMonitorId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CMDMonitorId = null;
	}
	
	/// <summary>
	/// Delete current TMSClassMonitorDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassMonitorDetails[] Search(System.Int64? cmdMonitorId, System.Int64? cmdStudentId, System.Int64? cmdFacultyId, System.Int64? cmdSchoolId, System.Int64? cmdSchoolSubId, System.String cmdMonthName, System.String cmdYear, System.String cmdMonitorType, System.DateTime? cmdDate, System.Int32? cmdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassMonitorDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cmdMonitorId, cmdStudentId, cmdFacultyId, cmdSchoolId, cmdSchoolSubId, cmdMonthName, cmdYear, cmdMonitorType, cmdDate, cmdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSClassMonitorDetails.MapFrom(ds);
	}
	
	
	public static TMSClassMonitorDetails[] Search(TMSClassMonitorDetails searchObject)
	{
		return Search ( searchObject.CMDMonitorId, searchObject.CMDStudentId, searchObject.CMDFacultyId, searchObject.CMDSchoolId, searchObject.CMDSchoolSubId, searchObject.CMDMonthName, searchObject.CMDYear, searchObject.CMDMonitorType, searchObject.CMDDate, searchObject.CMDStatus);
	}
	
	/// <summary>
	/// Returns all TMSClassMonitorDetails objects.
	/// </summary>
	/// <returns>List of all TMSClassMonitorDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSClassMonitorDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

