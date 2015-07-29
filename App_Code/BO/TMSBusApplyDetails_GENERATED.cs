/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/18/2012 10:24:03 AM                                    */
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
public partial class TMSBusApplyDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusApplyDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _badApplyId;
	private System.Int64? _badStudentId;
	private System.Int64? _badFacultyId;
	private System.Int64? _badBusId;
	private System.String _badSeatNumber;
	private System.String _badTravelingStatus;
	private System.DateTime? _badDate;
	private System.Int32? _badStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BADApplyId
	{
		get
		{
			return _badApplyId;
		}
		set
		{
			_badApplyId = value;
		}
	}
	
	public System.Int64? BADStudentId
	{
		get
		{
			return _badStudentId;
		}
		set
		{
			_badStudentId = value;
		}
	}
	
	public System.Int64? BADFacultyId
	{
		get
		{
			return _badFacultyId;
		}
		set
		{
			_badFacultyId = value;
		}
	}
	
	public System.Int64? BADBusId
	{
		get
		{
			return _badBusId;
		}
		set
		{
			_badBusId = value;
		}
	}
	
	public System.String BADSeatNumber
	{
		get
		{
			return _badSeatNumber;
		}
		set
		{
			_badSeatNumber = value;
		}
	}
	
	public System.String BADTravelingStatus
	{
		get
		{
			return _badTravelingStatus;
		}
		set
		{
			_badTravelingStatus = value;
		}
	}
	
	public System.DateTime? BADDate
	{
		get
		{
			return _badDate;
		}
		set
		{
			_badDate = value;
		}
	}
	
	public System.Int32? BADStatus
	{
		get
		{
			return _badStatus;
		}
		set
		{
			_badStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BAD_ApplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_StudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_BusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_SeatNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_TravelingStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BADApplyId == null)
		dr["BAD_ApplyId"] = DBNull.Value;
		else
		dr["BAD_ApplyId"] = BADApplyId;
		
		if (BADStudentId == null)
		dr["BAD_StudentId"] = DBNull.Value;
		else
		dr["BAD_StudentId"] = BADStudentId;
		
		if (BADFacultyId == null)
		dr["BAD_FacultyId"] = DBNull.Value;
		else
		dr["BAD_FacultyId"] = BADFacultyId;
		
		if (BADBusId == null)
		dr["BAD_BusId"] = DBNull.Value;
		else
		dr["BAD_BusId"] = BADBusId;
		
		if (BADSeatNumber == null)
		dr["BAD_SeatNumber"] = DBNull.Value;
		else
		dr["BAD_SeatNumber"] = BADSeatNumber;
		
		if (BADTravelingStatus == null)
		dr["BAD_TravelingStatus"] = DBNull.Value;
		else
		dr["BAD_TravelingStatus"] = BADTravelingStatus;
		
		if (BADDate == null)
		dr["BAD_Date"] = DBNull.Value;
		else
		dr["BAD_Date"] = BADDate;
		
		if (BADStatus == null)
		dr["BAD_Status"] = DBNull.Value;
		else
		dr["BAD_Status"] = BADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BADApplyId = dr["BAD_ApplyId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_ApplyId"]) : BADApplyId = null;
		BADStudentId = dr["BAD_StudentId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_StudentId"]) : BADStudentId = null;
		BADFacultyId = dr["BAD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_FacultyId"]) : BADFacultyId = null;
		BADBusId = dr["BAD_BusId"] != DBNull.Value ? Convert.ToInt64(dr["BAD_BusId"]) : BADBusId = null;
		BADSeatNumber = dr["BAD_SeatNumber"] != DBNull.Value ? Convert.ToString(dr["BAD_SeatNumber"]) : BADSeatNumber = null;
		BADTravelingStatus = dr["BAD_TravelingStatus"] != DBNull.Value ? Convert.ToString(dr["BAD_TravelingStatus"]) : BADTravelingStatus = null;
		BADDate = dr["BAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BAD_Date"]) : BADDate = null;
		BADStatus = dr["BAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BAD_Status"]) : BADStatus = null;
	}
	
	public static TMSBusApplyDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusApplyDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusApplyDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusApplyDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusApplyDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusApplyDetails instance = new TMSBusApplyDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusApplyDetails Get(System.Int64 badApplyId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusApplyDetails instance;
		
		
		instance = new TMSBusApplyDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badApplyId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusApplyDetails ID:" + badApplyId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badStudentId, badFacultyId, badBusId, badSeatNumber, badTravelingStatus, badDate, badStatus);
		
		if (transaction == null)
		this.BADApplyId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BADApplyId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus)
	{
		Insert(badStudentId, badFacultyId, badBusId, badSeatNumber, badTravelingStatus, badDate, badStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusApplyDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BADStudentId, BADFacultyId, BADBusId, BADSeatNumber, BADTravelingStatus, BADDate, BADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusApplyDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? badApplyId, System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@badApplyId"].Value = badApplyId;
		dbCommand.Parameters["@badStudentId"].Value = badStudentId;
		dbCommand.Parameters["@badFacultyId"].Value = badFacultyId;
		dbCommand.Parameters["@badBusId"].Value = badBusId;
		dbCommand.Parameters["@badSeatNumber"].Value = badSeatNumber;
		dbCommand.Parameters["@badTravelingStatus"].Value = badTravelingStatus;
		dbCommand.Parameters["@badDate"].Value = badDate;
		dbCommand.Parameters["@badStatus"].Value = badStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? badApplyId, System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus)
	{
		Update(badApplyId, badStudentId, badFacultyId, badBusId, badSeatNumber, badTravelingStatus, badDate, badStatus, null);
	}
	
	public static void Update(TMSBusApplyDetails tMSBusApplyDetails)
	{
		tMSBusApplyDetails.Update();
	}
	
	public static void Update(TMSBusApplyDetails tMSBusApplyDetails, DbTransaction transaction)
	{
		tMSBusApplyDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusApplyDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@badApplyId"].SourceColumn = "BAD_ApplyId";
		dbCommand.Parameters["@badStudentId"].SourceColumn = "BAD_StudentId";
		dbCommand.Parameters["@badFacultyId"].SourceColumn = "BAD_FacultyId";
		dbCommand.Parameters["@badBusId"].SourceColumn = "BAD_BusId";
		dbCommand.Parameters["@badSeatNumber"].SourceColumn = "BAD_SeatNumber";
		dbCommand.Parameters["@badTravelingStatus"].SourceColumn = "BAD_TravelingStatus";
		dbCommand.Parameters["@badDate"].SourceColumn = "BAD_Date";
		dbCommand.Parameters["@badStatus"].SourceColumn = "BAD_Status";
		
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
	public static void Delete(System.Int64? badApplyId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badApplyId);
		
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
	public static void Delete(System.Int64? badApplyId)
	{
		Delete(
		badApplyId);
	}
	
	/// <summary>
	/// Delete current TMSBusApplyDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BADApplyId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BADApplyId = null;
	}
	
	/// <summary>
	/// Delete current TMSBusApplyDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusApplyDetails[] Search(System.Int64? badApplyId, System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusApplyDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, badApplyId, badStudentId, badFacultyId, badBusId, badSeatNumber, badTravelingStatus, badDate, badStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusApplyDetails.MapFrom(ds);
	}
	
	
	public static TMSBusApplyDetails[] Search(TMSBusApplyDetails searchObject)
	{
		return Search ( searchObject.BADApplyId, searchObject.BADStudentId, searchObject.BADFacultyId, searchObject.BADBusId, searchObject.BADSeatNumber, searchObject.BADTravelingStatus, searchObject.BADDate, searchObject.BADStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusApplyDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusApplyDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusApplyDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

