/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/27/2012 3:49:45 PM                                    */
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
public partial class TMSBusMaintananceDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BusMaintananceDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bsmMentananceID;
	private System.String _bsmBusID;
	private System.Int64? _bsmBusDetailsId;
	private System.String _bsmBusNumber;
	private System.String _bsmBusTravels;
	private System.String _bsmBusMilage;
	private System.String _bsmMonth;
	private System.String _bsmYear;
	private System.Int64? _bsmBusRootID;
	private System.String _bsmMonthlyMaintenancecost;
	private System.String _bsmStartPoint;
	private System.String _bsmEndPoint;
	private System.String _bsmExtra;
	private System.DateTime? _bsmDate;
	private System.Int32? _bsmStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BSMMentananceID
	{
		get
		{
			return _bsmMentananceID;
		}
		set
		{
			_bsmMentananceID = value;
		}
	}
	
	public System.String BSMBusID
	{
		get
		{
			return _bsmBusID;
		}
		set
		{
			_bsmBusID = value;
		}
	}
	
	public System.Int64? BSMBusDetailsId
	{
		get
		{
			return _bsmBusDetailsId;
		}
		set
		{
			_bsmBusDetailsId = value;
		}
	}
	
	public System.String BSMBusNumber
	{
		get
		{
			return _bsmBusNumber;
		}
		set
		{
			_bsmBusNumber = value;
		}
	}
	
	public System.String BSMBusTravels
	{
		get
		{
			return _bsmBusTravels;
		}
		set
		{
			_bsmBusTravels = value;
		}
	}
	
	public System.String BSMBusMilage
	{
		get
		{
			return _bsmBusMilage;
		}
		set
		{
			_bsmBusMilage = value;
		}
	}
	
	public System.String BSMMonth
	{
		get
		{
			return _bsmMonth;
		}
		set
		{
			_bsmMonth = value;
		}
	}
	
	public System.String BSMYear
	{
		get
		{
			return _bsmYear;
		}
		set
		{
			_bsmYear = value;
		}
	}
	
	public System.Int64? BSMBusRootID
	{
		get
		{
			return _bsmBusRootID;
		}
		set
		{
			_bsmBusRootID = value;
		}
	}
	
	public System.String BSMMonthlyMaintenancecost
	{
		get
		{
			return _bsmMonthlyMaintenancecost;
		}
		set
		{
			_bsmMonthlyMaintenancecost = value;
		}
	}
	
	public System.String BSMStartPoint
	{
		get
		{
			return _bsmStartPoint;
		}
		set
		{
			_bsmStartPoint = value;
		}
	}
	
	public System.String BSMEndPoint
	{
		get
		{
			return _bsmEndPoint;
		}
		set
		{
			_bsmEndPoint = value;
		}
	}
	
	public System.String BSMExtra
	{
		get
		{
			return _bsmExtra;
		}
		set
		{
			_bsmExtra = value;
		}
	}
	
	public System.DateTime? BSMDate
	{
		get
		{
			return _bsmDate;
		}
		set
		{
			_bsmDate = value;
		}
	}
	
	public System.Int32? BSMStatus
	{
		get
		{
			return _bsmStatus;
		}
		set
		{
			_bsmStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BSM_MentananceID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusID", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusTravels", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusMilage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_BusRootID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_MonthlyMaintenancecost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_StartPoint", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_EndPoint", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BSM_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BSMMentananceID == null)
		dr["BSM_MentananceID"] = DBNull.Value;
		else
		dr["BSM_MentananceID"] = BSMMentananceID;
		
		if (BSMBusID == null)
		dr["BSM_BusID"] = DBNull.Value;
		else
		dr["BSM_BusID"] = BSMBusID;
		
		if (BSMBusDetailsId == null)
		dr["BSM_BusDetailsId"] = DBNull.Value;
		else
		dr["BSM_BusDetailsId"] = BSMBusDetailsId;
		
		if (BSMBusNumber == null)
		dr["BSM_BusNumber"] = DBNull.Value;
		else
		dr["BSM_BusNumber"] = BSMBusNumber;
		
		if (BSMBusTravels == null)
		dr["BSM_BusTravels"] = DBNull.Value;
		else
		dr["BSM_BusTravels"] = BSMBusTravels;
		
		if (BSMBusMilage == null)
		dr["BSM_BusMilage"] = DBNull.Value;
		else
		dr["BSM_BusMilage"] = BSMBusMilage;
		
		if (BSMMonth == null)
		dr["BSM_Month"] = DBNull.Value;
		else
		dr["BSM_Month"] = BSMMonth;
		
		if (BSMYear == null)
		dr["BSM_Year"] = DBNull.Value;
		else
		dr["BSM_Year"] = BSMYear;
		
		if (BSMBusRootID == null)
		dr["BSM_BusRootID"] = DBNull.Value;
		else
		dr["BSM_BusRootID"] = BSMBusRootID;
		
		if (BSMMonthlyMaintenancecost == null)
		dr["BSM_MonthlyMaintenancecost"] = DBNull.Value;
		else
		dr["BSM_MonthlyMaintenancecost"] = BSMMonthlyMaintenancecost;
		
		if (BSMStartPoint == null)
		dr["BSM_StartPoint"] = DBNull.Value;
		else
		dr["BSM_StartPoint"] = BSMStartPoint;
		
		if (BSMEndPoint == null)
		dr["BSM_EndPoint"] = DBNull.Value;
		else
		dr["BSM_EndPoint"] = BSMEndPoint;
		
		if (BSMExtra == null)
		dr["BSM_Extra"] = DBNull.Value;
		else
		dr["BSM_Extra"] = BSMExtra;
		
		if (BSMDate == null)
		dr["BSM_Date"] = DBNull.Value;
		else
		dr["BSM_Date"] = BSMDate;
		
		if (BSMStatus == null)
		dr["BSM_Status"] = DBNull.Value;
		else
		dr["BSM_Status"] = BSMStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BSMMentananceID = dr["BSM_MentananceID"] != DBNull.Value ? Convert.ToInt64(dr["BSM_MentananceID"]) : BSMMentananceID = null;
		BSMBusID = dr["BSM_BusID"] != DBNull.Value ? Convert.ToString(dr["BSM_BusID"]) : BSMBusID = null;
		BSMBusDetailsId = dr["BSM_BusDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["BSM_BusDetailsId"]) : BSMBusDetailsId = null;
		BSMBusNumber = dr["BSM_BusNumber"] != DBNull.Value ? Convert.ToString(dr["BSM_BusNumber"]) : BSMBusNumber = null;
		BSMBusTravels = dr["BSM_BusTravels"] != DBNull.Value ? Convert.ToString(dr["BSM_BusTravels"]) : BSMBusTravels = null;
		BSMBusMilage = dr["BSM_BusMilage"] != DBNull.Value ? Convert.ToString(dr["BSM_BusMilage"]) : BSMBusMilage = null;
		BSMMonth = dr["BSM_Month"] != DBNull.Value ? Convert.ToString(dr["BSM_Month"]) : BSMMonth = null;
		BSMYear = dr["BSM_Year"] != DBNull.Value ? Convert.ToString(dr["BSM_Year"]) : BSMYear = null;
		BSMBusRootID = dr["BSM_BusRootID"] != DBNull.Value ? Convert.ToInt64(dr["BSM_BusRootID"]) : BSMBusRootID = null;
		BSMMonthlyMaintenancecost = dr["BSM_MonthlyMaintenancecost"] != DBNull.Value ? Convert.ToString(dr["BSM_MonthlyMaintenancecost"]) : BSMMonthlyMaintenancecost = null;
		BSMStartPoint = dr["BSM_StartPoint"] != DBNull.Value ? Convert.ToString(dr["BSM_StartPoint"]) : BSMStartPoint = null;
		BSMEndPoint = dr["BSM_EndPoint"] != DBNull.Value ? Convert.ToString(dr["BSM_EndPoint"]) : BSMEndPoint = null;
		BSMExtra = dr["BSM_Extra"] != DBNull.Value ? Convert.ToString(dr["BSM_Extra"]) : BSMExtra = null;
		BSMDate = dr["BSM_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BSM_Date"]) : BSMDate = null;
		BSMStatus = dr["BSM_Status"] != DBNull.Value ? Convert.ToInt32(dr["BSM_Status"]) : BSMStatus = null;
	}
	
	public static TMSBusMaintananceDetails[] MapFrom(DataSet ds)
	{
		List<TMSBusMaintananceDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBusMaintananceDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BusMaintananceDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BusMaintananceDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBusMaintananceDetails instance = new TMSBusMaintananceDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusMaintananceDetails Get(System.Int64 bsmMentananceID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBusMaintananceDetails instance;
		
		
		instance = new TMSBusMaintananceDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsmMentananceID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBusMaintananceDetails ID:" + bsmMentananceID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsmBusID, bsmBusDetailsId, bsmBusNumber, bsmBusTravels, bsmBusMilage, bsmMonth, bsmYear, bsmBusRootID, bsmMonthlyMaintenancecost, bsmStartPoint, bsmEndPoint, bsmExtra, bsmDate, bsmStatus);
		
		if (transaction == null)
		this.BSMMentananceID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BSMMentananceID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus)
	{
		Insert(bsmBusID, bsmBusDetailsId, bsmBusNumber, bsmBusTravels, bsmBusMilage, bsmMonth, bsmYear, bsmBusRootID, bsmMonthlyMaintenancecost, bsmStartPoint, bsmEndPoint, bsmExtra, bsmDate, bsmStatus, null);
	}
	/// <summary>
	/// Insert current TMSBusMaintananceDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BSMBusID, BSMBusDetailsId, BSMBusNumber, BSMBusTravels, BSMBusMilage, BSMMonth, BSMYear, BSMBusRootID, BSMMonthlyMaintenancecost, BSMStartPoint, BSMEndPoint, BSMExtra, BSMDate, BSMStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBusMaintananceDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bsmMentananceID, System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bsmMentananceID"].Value = bsmMentananceID;
		dbCommand.Parameters["@bsmBusID"].Value = bsmBusID;
		dbCommand.Parameters["@bsmBusDetailsId"].Value = bsmBusDetailsId;
		dbCommand.Parameters["@bsmBusNumber"].Value = bsmBusNumber;
		dbCommand.Parameters["@bsmBusTravels"].Value = bsmBusTravels;
		dbCommand.Parameters["@bsmBusMilage"].Value = bsmBusMilage;
		dbCommand.Parameters["@bsmMonth"].Value = bsmMonth;
		dbCommand.Parameters["@bsmYear"].Value = bsmYear;
		dbCommand.Parameters["@bsmBusRootID"].Value = bsmBusRootID;
		dbCommand.Parameters["@bsmMonthlyMaintenancecost"].Value = bsmMonthlyMaintenancecost;
		dbCommand.Parameters["@bsmStartPoint"].Value = bsmStartPoint;
		dbCommand.Parameters["@bsmEndPoint"].Value = bsmEndPoint;
		dbCommand.Parameters["@bsmExtra"].Value = bsmExtra;
		dbCommand.Parameters["@bsmDate"].Value = bsmDate;
		dbCommand.Parameters["@bsmStatus"].Value = bsmStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bsmMentananceID, System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus)
	{
		Update(bsmMentananceID, bsmBusID, bsmBusDetailsId, bsmBusNumber, bsmBusTravels, bsmBusMilage, bsmMonth, bsmYear, bsmBusRootID, bsmMonthlyMaintenancecost, bsmStartPoint, bsmEndPoint, bsmExtra, bsmDate, bsmStatus, null);
	}
	
	public static void Update(TMSBusMaintananceDetails tMSBusMaintananceDetails)
	{
		tMSBusMaintananceDetails.Update();
	}
	
	public static void Update(TMSBusMaintananceDetails tMSBusMaintananceDetails, DbTransaction transaction)
	{
		tMSBusMaintananceDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bsmMentananceID"].SourceColumn = "BSM_MentananceID";
		dbCommand.Parameters["@bsmBusID"].SourceColumn = "BSM_BusID";
		dbCommand.Parameters["@bsmBusDetailsId"].SourceColumn = "BSM_BusDetailsId";
		dbCommand.Parameters["@bsmBusNumber"].SourceColumn = "BSM_BusNumber";
		dbCommand.Parameters["@bsmBusTravels"].SourceColumn = "BSM_BusTravels";
		dbCommand.Parameters["@bsmBusMilage"].SourceColumn = "BSM_BusMilage";
		dbCommand.Parameters["@bsmMonth"].SourceColumn = "BSM_Month";
		dbCommand.Parameters["@bsmYear"].SourceColumn = "BSM_Year";
		dbCommand.Parameters["@bsmBusRootID"].SourceColumn = "BSM_BusRootID";
		dbCommand.Parameters["@bsmMonthlyMaintenancecost"].SourceColumn = "BSM_MonthlyMaintenancecost";
		dbCommand.Parameters["@bsmStartPoint"].SourceColumn = "BSM_StartPoint";
		dbCommand.Parameters["@bsmEndPoint"].SourceColumn = "BSM_EndPoint";
		dbCommand.Parameters["@bsmExtra"].SourceColumn = "BSM_Extra";
		dbCommand.Parameters["@bsmDate"].SourceColumn = "BSM_Date";
		dbCommand.Parameters["@bsmStatus"].SourceColumn = "BSM_Status";
		
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
	public static void Delete(System.Int64? bsmMentananceID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsmMentananceID);
		
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
	public static void Delete(System.Int64? bsmMentananceID)
	{
		Delete(
		bsmMentananceID);
	}
	
	/// <summary>
	/// Delete current TMSBusMaintananceDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BSMMentananceID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BSMMentananceID = null;
	}
	
	/// <summary>
	/// Delete current TMSBusMaintananceDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBusMaintananceDetails[] Search(System.Int64? bsmMentananceID, System.String bsmBusID, System.Int64? bsmBusDetailsId, System.String bsmBusNumber, System.String bsmBusTravels, System.String bsmBusMilage, System.String bsmMonth, System.String bsmYear, System.Int64? bsmBusRootID, System.String bsmMonthlyMaintenancecost, System.String bsmStartPoint, System.String bsmEndPoint, System.String bsmExtra, System.DateTime? bsmDate, System.Int32? bsmStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBusMaintananceDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bsmMentananceID, bsmBusID, bsmBusDetailsId, bsmBusNumber, bsmBusTravels, bsmBusMilage, bsmMonth, bsmYear, bsmBusRootID, bsmMonthlyMaintenancecost, bsmStartPoint, bsmEndPoint, bsmExtra, bsmDate, bsmStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBusMaintananceDetails.MapFrom(ds);
	}
	
	
	public static TMSBusMaintananceDetails[] Search(TMSBusMaintananceDetails searchObject)
	{
		return Search ( searchObject.BSMMentananceID, searchObject.BSMBusID, searchObject.BSMBusDetailsId, searchObject.BSMBusNumber, searchObject.BSMBusTravels, searchObject.BSMBusMilage, searchObject.BSMMonth, searchObject.BSMYear, searchObject.BSMBusRootID, searchObject.BSMMonthlyMaintenancecost, searchObject.BSMStartPoint, searchObject.BSMEndPoint, searchObject.BSMExtra, searchObject.BSMDate, searchObject.BSMStatus);
	}
	
	/// <summary>
	/// Returns all TMSBusMaintananceDetails objects.
	/// </summary>
	/// <returns>List of all TMSBusMaintananceDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBusMaintananceDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

