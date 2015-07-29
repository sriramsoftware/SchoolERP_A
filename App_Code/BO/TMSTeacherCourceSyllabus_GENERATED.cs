/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/31/2012 2:53:32 PM                                    */
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
public partial class TMSTeacherCourceSyllabus
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TeacherCourceSyllabus]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tcTeacherSyllabusID;
	private System.Int64? _tcTeacherID;
	private System.Int64? _tcSyllabusID;
	private System.String _tcDescription;
	private System.DateTime? _tcStartDate;
	private System.DateTime? _tcEndDate;
	private System.String _tcpcpStatus;
	private System.Int32? _tcStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TCTeacherSyllabusID
	{
		get
		{
			return _tcTeacherSyllabusID;
		}
		set
		{
			_tcTeacherSyllabusID = value;
		}
	}
	
	public System.Int64? TCTeacherID
	{
		get
		{
			return _tcTeacherID;
		}
		set
		{
			_tcTeacherID = value;
		}
	}
	
	public System.Int64? TCSyllabusID
	{
		get
		{
			return _tcSyllabusID;
		}
		set
		{
			_tcSyllabusID = value;
		}
	}
	
	public System.String TCDescription
	{
		get
		{
			return _tcDescription;
		}
		set
		{
			_tcDescription = value;
		}
	}
	
	public System.DateTime? TCStartDate
	{
		get
		{
			return _tcStartDate;
		}
		set
		{
			_tcStartDate = value;
		}
	}
	
	public System.DateTime? TCEndDate
	{
		get
		{
			return _tcEndDate;
		}
		set
		{
			_tcEndDate = value;
		}
	}
	
	public System.String TCPCPStatus
	{
		get
		{
			return _tcpcpStatus;
		}
		set
		{
			_tcpcpStatus = value;
		}
	}
	
	public System.Int32? TCStatus
	{
		get
		{
			return _tcStatus;
		}
		set
		{
			_tcStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TC_TeacherSyllabusID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_TeacherID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_SyllabusID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_StartDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_EndDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_PCPStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TCTeacherSyllabusID == null)
		dr["TC_TeacherSyllabusID"] = DBNull.Value;
		else
		dr["TC_TeacherSyllabusID"] = TCTeacherSyllabusID;
		
		if (TCTeacherID == null)
		dr["TC_TeacherID"] = DBNull.Value;
		else
		dr["TC_TeacherID"] = TCTeacherID;
		
		if (TCSyllabusID == null)
		dr["TC_SyllabusID"] = DBNull.Value;
		else
		dr["TC_SyllabusID"] = TCSyllabusID;
		
		if (TCDescription == null)
		dr["TC_Description"] = DBNull.Value;
		else
		dr["TC_Description"] = TCDescription;
		
		if (TCStartDate == null)
		dr["TC_StartDate"] = DBNull.Value;
		else
		dr["TC_StartDate"] = TCStartDate;
		
		if (TCEndDate == null)
		dr["TC_EndDate"] = DBNull.Value;
		else
		dr["TC_EndDate"] = TCEndDate;
		
		if (TCPCPStatus == null)
		dr["TC_PCPStatus"] = DBNull.Value;
		else
		dr["TC_PCPStatus"] = TCPCPStatus;
		
		if (TCStatus == null)
		dr["TC_Status"] = DBNull.Value;
		else
		dr["TC_Status"] = TCStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TCTeacherSyllabusID = dr["TC_TeacherSyllabusID"] != DBNull.Value ? Convert.ToInt64(dr["TC_TeacherSyllabusID"]) : TCTeacherSyllabusID = null;
		TCTeacherID = dr["TC_TeacherID"] != DBNull.Value ? Convert.ToInt64(dr["TC_TeacherID"]) : TCTeacherID = null;
		TCSyllabusID = dr["TC_SyllabusID"] != DBNull.Value ? Convert.ToInt64(dr["TC_SyllabusID"]) : TCSyllabusID = null;
		TCDescription = dr["TC_Description"] != DBNull.Value ? Convert.ToString(dr["TC_Description"]) : TCDescription = null;
		TCStartDate = dr["TC_StartDate"] != DBNull.Value ? Convert.ToDateTime(dr["TC_StartDate"]) : TCStartDate = null;
		TCEndDate = dr["TC_EndDate"] != DBNull.Value ? Convert.ToDateTime(dr["TC_EndDate"]) : TCEndDate = null;
		TCPCPStatus = dr["TC_PCPStatus"] != DBNull.Value ? Convert.ToString(dr["TC_PCPStatus"]) : TCPCPStatus = null;
		TCStatus = dr["TC_Status"] != DBNull.Value ? Convert.ToInt32(dr["TC_Status"]) : TCStatus = null;
	}
	
	public static TMSTeacherCourceSyllabus[] MapFrom(DataSet ds)
	{
		List<TMSTeacherCourceSyllabus> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTeacherCourceSyllabus>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TeacherCourceSyllabus] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TeacherCourceSyllabus] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTeacherCourceSyllabus instance = new TMSTeacherCourceSyllabus();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTeacherCourceSyllabus Get(System.Int64 tcTeacherSyllabusID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTeacherCourceSyllabus instance;
		
		
		instance = new TMSTeacherCourceSyllabus();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tcTeacherSyllabusID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSTeacherCourceSyllabus ID:" + tcTeacherSyllabusID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tcTeacherID, tcSyllabusID, tcDescription, tcStartDate, tcEndDate, tcpcpStatus, tcStatus);
		
		if (transaction == null)
		this.TCTeacherSyllabusID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TCTeacherSyllabusID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus)
	{
		Insert(tcTeacherID, tcSyllabusID, tcDescription, tcStartDate, tcEndDate, tcpcpStatus, tcStatus, null);
	}
	/// <summary>
	/// Insert current TMSTeacherCourceSyllabus to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TCTeacherID, TCSyllabusID, TCDescription, TCStartDate, TCEndDate, TCPCPStatus, TCStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTeacherCourceSyllabus to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tcTeacherSyllabusID, System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tcTeacherSyllabusID"].Value = tcTeacherSyllabusID;
		dbCommand.Parameters["@tcTeacherID"].Value = tcTeacherID;
		dbCommand.Parameters["@tcSyllabusID"].Value = tcSyllabusID;
		dbCommand.Parameters["@tcDescription"].Value = tcDescription;
		dbCommand.Parameters["@tcStartDate"].Value = tcStartDate;
		dbCommand.Parameters["@tcEndDate"].Value = tcEndDate;
		dbCommand.Parameters["@tcpcpStatus"].Value = tcpcpStatus;
		dbCommand.Parameters["@tcStatus"].Value = tcStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tcTeacherSyllabusID, System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus)
	{
		Update(tcTeacherSyllabusID, tcTeacherID, tcSyllabusID, tcDescription, tcStartDate, tcEndDate, tcpcpStatus, tcStatus, null);
	}
	
	public static void Update(TMSTeacherCourceSyllabus tMSTeacherCourceSyllabus)
	{
		tMSTeacherCourceSyllabus.Update();
	}
	
	public static void Update(TMSTeacherCourceSyllabus tMSTeacherCourceSyllabus, DbTransaction transaction)
	{
		tMSTeacherCourceSyllabus.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tcTeacherSyllabusID"].SourceColumn = "TC_TeacherSyllabusID";
		dbCommand.Parameters["@tcTeacherID"].SourceColumn = "TC_TeacherID";
		dbCommand.Parameters["@tcSyllabusID"].SourceColumn = "TC_SyllabusID";
		dbCommand.Parameters["@tcDescription"].SourceColumn = "TC_Description";
		dbCommand.Parameters["@tcStartDate"].SourceColumn = "TC_StartDate";
		dbCommand.Parameters["@tcEndDate"].SourceColumn = "TC_EndDate";
		dbCommand.Parameters["@tcpcpStatus"].SourceColumn = "TC_PCPStatus";
		dbCommand.Parameters["@tcStatus"].SourceColumn = "TC_Status";
		
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
	public static void Delete(System.Int64? tcTeacherSyllabusID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tcTeacherSyllabusID);
		
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
	public static void Delete(System.Int64? tcTeacherSyllabusID)
	{
		Delete(
		tcTeacherSyllabusID);
	}
	
	/// <summary>
	/// Delete current TMSTeacherCourceSyllabus from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TCTeacherSyllabusID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TCTeacherSyllabusID = null;
	}
	
	/// <summary>
	/// Delete current TMSTeacherCourceSyllabus from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTeacherCourceSyllabus[] Search(System.Int64? tcTeacherSyllabusID, System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tcTeacherSyllabusID, tcTeacherID, tcSyllabusID, tcDescription, tcStartDate, tcEndDate, tcpcpStatus, tcStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTeacherCourceSyllabus.MapFrom(ds);
	}
	
	
	public static TMSTeacherCourceSyllabus[] Search(TMSTeacherCourceSyllabus searchObject)
	{
		return Search ( searchObject.TCTeacherSyllabusID, searchObject.TCTeacherID, searchObject.TCSyllabusID, searchObject.TCDescription, searchObject.TCStartDate, searchObject.TCEndDate, searchObject.TCPCPStatus, searchObject.TCStatus);
	}
	
	/// <summary>
	/// Returns all TMSTeacherCourceSyllabus objects.
	/// </summary>
	/// <returns>List of all TMSTeacherCourceSyllabus objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTeacherCourceSyllabus[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

