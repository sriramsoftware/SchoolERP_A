/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/8/2012 6:59:16 PM                                    */
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
public partial class TMSEventCalendar
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EventCalendar]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ecEventId;
	private System.Int64? _ecDepartmentId;
	private System.Int64? _ecFacultyId;
	private System.Int64? _ecSchoolCategoryId;
	private System.Int64? _ecSubSchoolCategoryId;
	private System.String _ecEventName;
	private System.String _ecEventDescriptionOne;
	private System.String _ecEventDescriptionTwo;
	private System.String _ecEventYear;
	private System.String _ecEventStartTime;
	private System.String _ecEventEndTime;
	private System.DateTime? _ecEventStartDate;
	private System.DateTime? _ecEventEndDate;
	private System.String _ecEventImageOne;
	private System.String _ecEventImageTwo;
	private System.DateTime? _ecEventAddDate;
	private System.Int64? _ecEventAddedby;
	private System.Int32? _ecStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ECEventId
	{
		get
		{
			return _ecEventId;
		}
		set
		{
			_ecEventId = value;
		}
	}
	
	public System.Int64? ECDepartmentId
	{
		get
		{
			return _ecDepartmentId;
		}
		set
		{
			_ecDepartmentId = value;
		}
	}
	
	public System.Int64? ECFacultyId
	{
		get
		{
			return _ecFacultyId;
		}
		set
		{
			_ecFacultyId = value;
		}
	}
	
	public System.Int64? ECSchoolCategoryId
	{
		get
		{
			return _ecSchoolCategoryId;
		}
		set
		{
			_ecSchoolCategoryId = value;
		}
	}
	
	public System.Int64? ECSubSchoolCategoryId
	{
		get
		{
			return _ecSubSchoolCategoryId;
		}
		set
		{
			_ecSubSchoolCategoryId = value;
		}
	}
	
	public System.String ECEventName
	{
		get
		{
			return _ecEventName;
		}
		set
		{
			_ecEventName = value;
		}
	}
	
	public System.String ECEventDescriptionOne
	{
		get
		{
			return _ecEventDescriptionOne;
		}
		set
		{
			_ecEventDescriptionOne = value;
		}
	}
	
	public System.String ECEventDescriptionTwo
	{
		get
		{
			return _ecEventDescriptionTwo;
		}
		set
		{
			_ecEventDescriptionTwo = value;
		}
	}
	
	public System.String ECEventYear
	{
		get
		{
			return _ecEventYear;
		}
		set
		{
			_ecEventYear = value;
		}
	}
	
	public System.String ECEventStartTime
	{
		get
		{
			return _ecEventStartTime;
		}
		set
		{
			_ecEventStartTime = value;
		}
	}
	
	public System.String ECEventEndTime
	{
		get
		{
			return _ecEventEndTime;
		}
		set
		{
			_ecEventEndTime = value;
		}
	}
	
	public System.DateTime? ECEventStartDate
	{
		get
		{
			return _ecEventStartDate;
		}
		set
		{
			_ecEventStartDate = value;
		}
	}
	
	public System.DateTime? ECEventEndDate
	{
		get
		{
			return _ecEventEndDate;
		}
		set
		{
			_ecEventEndDate = value;
		}
	}
	
	public System.String ECEventImageOne
	{
		get
		{
			return _ecEventImageOne;
		}
		set
		{
			_ecEventImageOne = value;
		}
	}
	
	public System.String ECEventImageTwo
	{
		get
		{
			return _ecEventImageTwo;
		}
		set
		{
			_ecEventImageTwo = value;
		}
	}
	
	public System.DateTime? ECEventAddDate
	{
		get
		{
			return _ecEventAddDate;
		}
		set
		{
			_ecEventAddDate = value;
		}
	}
	
	public System.Int64? ECEventAddedby
	{
		get
		{
			return _ecEventAddedby;
		}
		set
		{
			_ecEventAddedby = value;
		}
	}
	
	public System.Int32? ECStatus
	{
		get
		{
			return _ecStatus;
		}
		set
		{
			_ecStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_DepartmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_SchoolCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_SubSchoolCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventDescriptionOne", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventDescriptionTwo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventYear", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventStartTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventEndTime", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventStartDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventEndDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventImageOne", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventImageTwo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventAddDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_EventAddedby", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ECEventId == null)
		dr["EC_EventId"] = DBNull.Value;
		else
		dr["EC_EventId"] = ECEventId;
		
		if (ECDepartmentId == null)
		dr["EC_DepartmentId"] = DBNull.Value;
		else
		dr["EC_DepartmentId"] = ECDepartmentId;
		
		if (ECFacultyId == null)
		dr["EC_FacultyId"] = DBNull.Value;
		else
		dr["EC_FacultyId"] = ECFacultyId;
		
		if (ECSchoolCategoryId == null)
		dr["EC_SchoolCategoryId"] = DBNull.Value;
		else
		dr["EC_SchoolCategoryId"] = ECSchoolCategoryId;
		
		if (ECSubSchoolCategoryId == null)
		dr["EC_SubSchoolCategoryId"] = DBNull.Value;
		else
		dr["EC_SubSchoolCategoryId"] = ECSubSchoolCategoryId;
		
		if (ECEventName == null)
		dr["EC_EventName"] = DBNull.Value;
		else
		dr["EC_EventName"] = ECEventName;
		
		if (ECEventDescriptionOne == null)
		dr["EC_EventDescriptionOne"] = DBNull.Value;
		else
		dr["EC_EventDescriptionOne"] = ECEventDescriptionOne;
		
		if (ECEventDescriptionTwo == null)
		dr["EC_EventDescriptionTwo"] = DBNull.Value;
		else
		dr["EC_EventDescriptionTwo"] = ECEventDescriptionTwo;
		
		if (ECEventYear == null)
		dr["EC_EventYear"] = DBNull.Value;
		else
		dr["EC_EventYear"] = ECEventYear;
		
		if (ECEventStartTime == null)
		dr["EC_EventStartTime"] = DBNull.Value;
		else
		dr["EC_EventStartTime"] = ECEventStartTime;
		
		if (ECEventEndTime == null)
		dr["EC_EventEndTime"] = DBNull.Value;
		else
		dr["EC_EventEndTime"] = ECEventEndTime;
		
		if (ECEventStartDate == null)
		dr["EC_EventStartDate"] = DBNull.Value;
		else
		dr["EC_EventStartDate"] = ECEventStartDate;
		
		if (ECEventEndDate == null)
		dr["EC_EventEndDate"] = DBNull.Value;
		else
		dr["EC_EventEndDate"] = ECEventEndDate;
		
		if (ECEventImageOne == null)
		dr["EC_EventImageOne"] = DBNull.Value;
		else
		dr["EC_EventImageOne"] = ECEventImageOne;
		
		if (ECEventImageTwo == null)
		dr["EC_EventImageTwo"] = DBNull.Value;
		else
		dr["EC_EventImageTwo"] = ECEventImageTwo;
		
		if (ECEventAddDate == null)
		dr["EC_EventAddDate"] = DBNull.Value;
		else
		dr["EC_EventAddDate"] = ECEventAddDate;
		
		if (ECEventAddedby == null)
		dr["EC_EventAddedby"] = DBNull.Value;
		else
		dr["EC_EventAddedby"] = ECEventAddedby;
		
		if (ECStatus == null)
		dr["EC_Status"] = DBNull.Value;
		else
		dr["EC_Status"] = ECStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ECEventId = dr["EC_EventId"] != DBNull.Value ? Convert.ToInt64(dr["EC_EventId"]) : ECEventId = null;
		ECDepartmentId = dr["EC_DepartmentId"] != DBNull.Value ? Convert.ToInt64(dr["EC_DepartmentId"]) : ECDepartmentId = null;
		ECFacultyId = dr["EC_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["EC_FacultyId"]) : ECFacultyId = null;
		ECSchoolCategoryId = dr["EC_SchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["EC_SchoolCategoryId"]) : ECSchoolCategoryId = null;
		ECSubSchoolCategoryId = dr["EC_SubSchoolCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["EC_SubSchoolCategoryId"]) : ECSubSchoolCategoryId = null;
		ECEventName = dr["EC_EventName"] != DBNull.Value ? Convert.ToString(dr["EC_EventName"]) : ECEventName = null;
		ECEventDescriptionOne = dr["EC_EventDescriptionOne"] != DBNull.Value ? Convert.ToString(dr["EC_EventDescriptionOne"]) : ECEventDescriptionOne = null;
		ECEventDescriptionTwo = dr["EC_EventDescriptionTwo"] != DBNull.Value ? Convert.ToString(dr["EC_EventDescriptionTwo"]) : ECEventDescriptionTwo = null;
		ECEventYear = dr["EC_EventYear"] != DBNull.Value ? Convert.ToString(dr["EC_EventYear"]) : ECEventYear = null;
		ECEventStartTime = dr["EC_EventStartTime"] != DBNull.Value ? Convert.ToString(dr["EC_EventStartTime"]) : ECEventStartTime = null;
		ECEventEndTime = dr["EC_EventEndTime"] != DBNull.Value ? Convert.ToString(dr["EC_EventEndTime"]) : ECEventEndTime = null;
		ECEventStartDate = dr["EC_EventStartDate"] != DBNull.Value ? Convert.ToDateTime(dr["EC_EventStartDate"]) : ECEventStartDate = null;
		ECEventEndDate = dr["EC_EventEndDate"] != DBNull.Value ? Convert.ToDateTime(dr["EC_EventEndDate"]) : ECEventEndDate = null;
		ECEventImageOne = dr["EC_EventImageOne"] != DBNull.Value ? Convert.ToString(dr["EC_EventImageOne"]) : ECEventImageOne = null;
		ECEventImageTwo = dr["EC_EventImageTwo"] != DBNull.Value ? Convert.ToString(dr["EC_EventImageTwo"]) : ECEventImageTwo = null;
		ECEventAddDate = dr["EC_EventAddDate"] != DBNull.Value ? Convert.ToDateTime(dr["EC_EventAddDate"]) : ECEventAddDate = null;
		ECEventAddedby = dr["EC_EventAddedby"] != DBNull.Value ? Convert.ToInt64(dr["EC_EventAddedby"]) : ECEventAddedby = null;
		ECStatus = dr["EC_Status"] != DBNull.Value ? Convert.ToInt32(dr["EC_Status"]) : ECStatus = null;
	}
	
	public static TMSEventCalendar[] MapFrom(DataSet ds)
	{
		List<TMSEventCalendar> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEventCalendar>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EventCalendar] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EventCalendar] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEventCalendar instance = new TMSEventCalendar();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEventCalendar Get(System.Int64 ecEventId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEventCalendar instance;
		
		
		instance = new TMSEventCalendar();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSEventCalendar ID:" + ecEventId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus);
		
		if (transaction == null)
		this.ECEventId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ECEventId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus)
	{
		Insert(ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus, null);
	}
	/// <summary>
	/// Insert current TMSEventCalendar to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ECDepartmentId, ECFacultyId, ECSchoolCategoryId, ECSubSchoolCategoryId, ECEventName, ECEventDescriptionOne, ECEventDescriptionTwo, ECEventYear, ECEventStartTime, ECEventEndTime, ECEventStartDate, ECEventEndDate, ECEventImageOne, ECEventImageTwo, ECEventAddDate, ECEventAddedby, ECStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEventCalendar to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ecEventId, System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ecEventId"].Value = ecEventId;
		dbCommand.Parameters["@ecDepartmentId"].Value = ecDepartmentId;
		dbCommand.Parameters["@ecFacultyId"].Value = ecFacultyId;
		dbCommand.Parameters["@ecSchoolCategoryId"].Value = ecSchoolCategoryId;
		dbCommand.Parameters["@ecSubSchoolCategoryId"].Value = ecSubSchoolCategoryId;
		dbCommand.Parameters["@ecEventName"].Value = ecEventName;
		dbCommand.Parameters["@ecEventDescriptionOne"].Value = ecEventDescriptionOne;
		dbCommand.Parameters["@ecEventDescriptionTwo"].Value = ecEventDescriptionTwo;
		dbCommand.Parameters["@ecEventYear"].Value = ecEventYear;
		dbCommand.Parameters["@ecEventStartTime"].Value = ecEventStartTime;
		dbCommand.Parameters["@ecEventEndTime"].Value = ecEventEndTime;
		dbCommand.Parameters["@ecEventStartDate"].Value = ecEventStartDate;
		dbCommand.Parameters["@ecEventEndDate"].Value = ecEventEndDate;
		dbCommand.Parameters["@ecEventImageOne"].Value = ecEventImageOne;
		dbCommand.Parameters["@ecEventImageTwo"].Value = ecEventImageTwo;
		dbCommand.Parameters["@ecEventAddDate"].Value = ecEventAddDate;
		dbCommand.Parameters["@ecEventAddedby"].Value = ecEventAddedby;
		dbCommand.Parameters["@ecStatus"].Value = ecStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ecEventId, System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus)
	{
		Update(ecEventId, ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus, null);
	}
	
	public static void Update(TMSEventCalendar tMSEventCalendar)
	{
		tMSEventCalendar.Update();
	}
	
	public static void Update(TMSEventCalendar tMSEventCalendar, DbTransaction transaction)
	{
		tMSEventCalendar.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEventCalendar_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ecEventId"].SourceColumn = "EC_EventId";
		dbCommand.Parameters["@ecDepartmentId"].SourceColumn = "EC_DepartmentId";
		dbCommand.Parameters["@ecFacultyId"].SourceColumn = "EC_FacultyId";
		dbCommand.Parameters["@ecSchoolCategoryId"].SourceColumn = "EC_SchoolCategoryId";
		dbCommand.Parameters["@ecSubSchoolCategoryId"].SourceColumn = "EC_SubSchoolCategoryId";
		dbCommand.Parameters["@ecEventName"].SourceColumn = "EC_EventName";
		dbCommand.Parameters["@ecEventDescriptionOne"].SourceColumn = "EC_EventDescriptionOne";
		dbCommand.Parameters["@ecEventDescriptionTwo"].SourceColumn = "EC_EventDescriptionTwo";
		dbCommand.Parameters["@ecEventYear"].SourceColumn = "EC_EventYear";
		dbCommand.Parameters["@ecEventStartTime"].SourceColumn = "EC_EventStartTime";
		dbCommand.Parameters["@ecEventEndTime"].SourceColumn = "EC_EventEndTime";
		dbCommand.Parameters["@ecEventStartDate"].SourceColumn = "EC_EventStartDate";
		dbCommand.Parameters["@ecEventEndDate"].SourceColumn = "EC_EventEndDate";
		dbCommand.Parameters["@ecEventImageOne"].SourceColumn = "EC_EventImageOne";
		dbCommand.Parameters["@ecEventImageTwo"].SourceColumn = "EC_EventImageTwo";
		dbCommand.Parameters["@ecEventAddDate"].SourceColumn = "EC_EventAddDate";
		dbCommand.Parameters["@ecEventAddedby"].SourceColumn = "EC_EventAddedby";
		dbCommand.Parameters["@ecStatus"].SourceColumn = "EC_Status";
		
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
	public static void Delete(System.Int64? ecEventId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId);
		
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
	public static void Delete(System.Int64? ecEventId)
	{
		Delete(
		ecEventId);
	}
	
	/// <summary>
	/// Delete current TMSEventCalendar from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ECEventId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ECEventId = null;
	}
	
	/// <summary>
	/// Delete current TMSEventCalendar from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEventCalendar[] Search(System.Int64? ecEventId, System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventCalendar_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId, ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEventCalendar.MapFrom(ds);
	}
	
	
	public static TMSEventCalendar[] Search(TMSEventCalendar searchObject)
	{
		return Search ( searchObject.ECEventId, searchObject.ECDepartmentId, searchObject.ECFacultyId, searchObject.ECSchoolCategoryId, searchObject.ECSubSchoolCategoryId, searchObject.ECEventName, searchObject.ECEventDescriptionOne, searchObject.ECEventDescriptionTwo, searchObject.ECEventYear, searchObject.ECEventStartTime, searchObject.ECEventEndTime, searchObject.ECEventStartDate, searchObject.ECEventEndDate, searchObject.ECEventImageOne, searchObject.ECEventImageTwo, searchObject.ECEventAddDate, searchObject.ECEventAddedby, searchObject.ECStatus);
	}
	
	/// <summary>
	/// Returns all TMSEventCalendar objects.
	/// </summary>
	/// <returns>List of all TMSEventCalendar objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEventCalendar[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

