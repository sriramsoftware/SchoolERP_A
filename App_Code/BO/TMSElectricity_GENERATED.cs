/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/22/2012 1:37:57 PM                                    */
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
public partial class TMSElectricity
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Electricity]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _elEbillID;
	private System.Double? _elBillAmount;
	private System.Double? _elLateFees;
	private System.String _elMonth;
	private System.String _elYear;
	private System.DateTime? _elLastDate;
	private System.DateTime? _elBillPaidDate;
	private System.Double? _elTotalAmount;
	private System.String _elPaidStatus;
	private System.String _elbIllno;
	private System.String _elBillFile;
	private System.String _elExtra1;
	private System.String _elExtra2;
	private System.DateTime? _elDate;
	private System.Int32? _elStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ElEbillID
	{
		get
		{
			return _elEbillID;
		}
		set
		{
			_elEbillID = value;
		}
	}
	
	public System.Double? ELBillAmount
	{
		get
		{
			return _elBillAmount;
		}
		set
		{
			_elBillAmount = value;
		}
	}
	
	public System.Double? ELLateFees
	{
		get
		{
			return _elLateFees;
		}
		set
		{
			_elLateFees = value;
		}
	}
	
	public System.String ELMonth
	{
		get
		{
			return _elMonth;
		}
		set
		{
			_elMonth = value;
		}
	}
	
	public System.String ElYear
	{
		get
		{
			return _elYear;
		}
		set
		{
			_elYear = value;
		}
	}
	
	public System.DateTime? ElLastDate
	{
		get
		{
			return _elLastDate;
		}
		set
		{
			_elLastDate = value;
		}
	}
	
	public System.DateTime? ElBillPaidDate
	{
		get
		{
			return _elBillPaidDate;
		}
		set
		{
			_elBillPaidDate = value;
		}
	}
	
	public System.Double? ELTotalAmount
	{
		get
		{
			return _elTotalAmount;
		}
		set
		{
			_elTotalAmount = value;
		}
	}
	
	public System.String ELPaidStatus
	{
		get
		{
			return _elPaidStatus;
		}
		set
		{
			_elPaidStatus = value;
		}
	}
	
	public System.String ELBIllno
	{
		get
		{
			return _elbIllno;
		}
		set
		{
			_elbIllno = value;
		}
	}
	
	public System.String ELBillFile
	{
		get
		{
			return _elBillFile;
		}
		set
		{
			_elBillFile = value;
		}
	}
	
	public System.String ELExtra1
	{
		get
		{
			return _elExtra1;
		}
		set
		{
			_elExtra1 = value;
		}
	}
	
	public System.String ELExtra2
	{
		get
		{
			return _elExtra2;
		}
		set
		{
			_elExtra2 = value;
		}
	}
	
	public System.DateTime? ELDate
	{
		get
		{
			return _elDate;
		}
		set
		{
			_elDate = value;
		}
	}
	
	public System.Int32? ELStatus
	{
		get
		{
			return _elStatus;
		}
		set
		{
			_elStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("El_EbillID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_BillAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_LateFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("El_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("El_LastDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("El_BillPaidDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_TotalAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_PaidStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_BIllno", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_BillFile", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ElEbillID == null)
		dr["El_EbillID"] = DBNull.Value;
		else
		dr["El_EbillID"] = ElEbillID;
		
		if (ELBillAmount == null)
		dr["EL_BillAmount"] = DBNull.Value;
		else
		dr["EL_BillAmount"] = ELBillAmount;
		
		if (ELLateFees == null)
		dr["EL_LateFees"] = DBNull.Value;
		else
		dr["EL_LateFees"] = ELLateFees;
		
		if (ELMonth == null)
		dr["EL_Month"] = DBNull.Value;
		else
		dr["EL_Month"] = ELMonth;
		
		if (ElYear == null)
		dr["El_Year"] = DBNull.Value;
		else
		dr["El_Year"] = ElYear;
		
		if (ElLastDate == null)
		dr["El_LastDate"] = DBNull.Value;
		else
		dr["El_LastDate"] = ElLastDate;
		
		if (ElBillPaidDate == null)
		dr["El_BillPaidDate"] = DBNull.Value;
		else
		dr["El_BillPaidDate"] = ElBillPaidDate;
		
		if (ELTotalAmount == null)
		dr["EL_TotalAmount"] = DBNull.Value;
		else
		dr["EL_TotalAmount"] = ELTotalAmount;
		
		if (ELPaidStatus == null)
		dr["EL_PaidStatus"] = DBNull.Value;
		else
		dr["EL_PaidStatus"] = ELPaidStatus;
		
		if (ELBIllno == null)
		dr["EL_BIllno"] = DBNull.Value;
		else
		dr["EL_BIllno"] = ELBIllno;
		
		if (ELBillFile == null)
		dr["EL_BillFile"] = DBNull.Value;
		else
		dr["EL_BillFile"] = ELBillFile;
		
		if (ELExtra1 == null)
		dr["EL_Extra1"] = DBNull.Value;
		else
		dr["EL_Extra1"] = ELExtra1;
		
		if (ELExtra2 == null)
		dr["EL_Extra2"] = DBNull.Value;
		else
		dr["EL_Extra2"] = ELExtra2;
		
		if (ELDate == null)
		dr["EL_Date"] = DBNull.Value;
		else
		dr["EL_Date"] = ELDate;
		
		if (ELStatus == null)
		dr["EL_Status"] = DBNull.Value;
		else
		dr["EL_Status"] = ELStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ElEbillID = dr["El_EbillID"] != DBNull.Value ? Convert.ToInt64(dr["El_EbillID"]) : ElEbillID = null;
		ELBillAmount = dr["EL_BillAmount"] != DBNull.Value ? Convert.ToDouble(dr["EL_BillAmount"]) : ELBillAmount = null;
		ELLateFees = dr["EL_LateFees"] != DBNull.Value ? Convert.ToDouble(dr["EL_LateFees"]) : ELLateFees = null;
		ELMonth = dr["EL_Month"] != DBNull.Value ? Convert.ToString(dr["EL_Month"]) : ELMonth = null;
		ElYear = dr["El_Year"] != DBNull.Value ? Convert.ToString(dr["El_Year"]) : ElYear = null;
		ElLastDate = dr["El_LastDate"] != DBNull.Value ? Convert.ToDateTime(dr["El_LastDate"]) : ElLastDate = null;
		ElBillPaidDate = dr["El_BillPaidDate"] != DBNull.Value ? Convert.ToDateTime(dr["El_BillPaidDate"]) : ElBillPaidDate = null;
		ELTotalAmount = dr["EL_TotalAmount"] != DBNull.Value ? Convert.ToDouble(dr["EL_TotalAmount"]) : ELTotalAmount = null;
		ELPaidStatus = dr["EL_PaidStatus"] != DBNull.Value ? Convert.ToString(dr["EL_PaidStatus"]) : ELPaidStatus = null;
		ELBIllno = dr["EL_BIllno"] != DBNull.Value ? Convert.ToString(dr["EL_BIllno"]) : ELBIllno = null;
		ELBillFile = dr["EL_BillFile"] != DBNull.Value ? Convert.ToString(dr["EL_BillFile"]) : ELBillFile = null;
		ELExtra1 = dr["EL_Extra1"] != DBNull.Value ? Convert.ToString(dr["EL_Extra1"]) : ELExtra1 = null;
		ELExtra2 = dr["EL_Extra2"] != DBNull.Value ? Convert.ToString(dr["EL_Extra2"]) : ELExtra2 = null;
		ELDate = dr["EL_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EL_Date"]) : ELDate = null;
		ELStatus = dr["EL_Status"] != DBNull.Value ? Convert.ToInt32(dr["EL_Status"]) : ELStatus = null;
	}
	
	public static TMSElectricity[] MapFrom(DataSet ds)
	{
		List<TMSElectricity> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSElectricity>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Electricity] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Electricity] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSElectricity instance = new TMSElectricity();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSElectricity Get(System.Int64 elEbillID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSElectricity instance;
		
		
		instance = new TMSElectricity();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSElectricity ID:" + elEbillID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elbIllno, elBillFile, elExtra1, elExtra2, elDate, elStatus);
		
		if (transaction == null)
		this.ElEbillID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ElEbillID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus)
	{
		Insert(elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elbIllno, elBillFile, elExtra1, elExtra2, elDate, elStatus, null);
	}
	/// <summary>
	/// Insert current TMSElectricity to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ELBillAmount, ELLateFees, ELMonth, ElYear, ElLastDate, ElBillPaidDate, ELTotalAmount, ELPaidStatus, ELBIllno, ELBillFile, ELExtra1, ELExtra2, ELDate, ELStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSElectricity to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@elEbillID"].Value = elEbillID;
		dbCommand.Parameters["@elBillAmount"].Value = elBillAmount;
		dbCommand.Parameters["@elLateFees"].Value = elLateFees;
		dbCommand.Parameters["@elMonth"].Value = elMonth;
		dbCommand.Parameters["@elYear"].Value = elYear;
		dbCommand.Parameters["@elLastDate"].Value = elLastDate;
		dbCommand.Parameters["@elBillPaidDate"].Value = elBillPaidDate;
		dbCommand.Parameters["@elTotalAmount"].Value = elTotalAmount;
		dbCommand.Parameters["@elPaidStatus"].Value = elPaidStatus;
		dbCommand.Parameters["@elbIllno"].Value = elbIllno;
		dbCommand.Parameters["@elBillFile"].Value = elBillFile;
		dbCommand.Parameters["@elExtra1"].Value = elExtra1;
		dbCommand.Parameters["@elExtra2"].Value = elExtra2;
		dbCommand.Parameters["@elDate"].Value = elDate;
		dbCommand.Parameters["@elStatus"].Value = elStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus)
	{
		Update(elEbillID, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elbIllno, elBillFile, elExtra1, elExtra2, elDate, elStatus, null);
	}
	
	public static void Update(TMSElectricity tMSElectricity)
	{
		tMSElectricity.Update();
	}
	
	public static void Update(TMSElectricity tMSElectricity, DbTransaction transaction)
	{
		tMSElectricity.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSElectricity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@elEbillID"].SourceColumn = "El_EbillID";
		dbCommand.Parameters["@elBillAmount"].SourceColumn = "EL_BillAmount";
		dbCommand.Parameters["@elLateFees"].SourceColumn = "EL_LateFees";
		dbCommand.Parameters["@elMonth"].SourceColumn = "EL_Month";
		dbCommand.Parameters["@elYear"].SourceColumn = "El_Year";
		dbCommand.Parameters["@elLastDate"].SourceColumn = "El_LastDate";
		dbCommand.Parameters["@elBillPaidDate"].SourceColumn = "El_BillPaidDate";
		dbCommand.Parameters["@elTotalAmount"].SourceColumn = "EL_TotalAmount";
		dbCommand.Parameters["@elPaidStatus"].SourceColumn = "EL_PaidStatus";
		dbCommand.Parameters["@elbIllno"].SourceColumn = "EL_BIllno";
		dbCommand.Parameters["@elBillFile"].SourceColumn = "EL_BillFile";
		dbCommand.Parameters["@elExtra1"].SourceColumn = "EL_Extra1";
		dbCommand.Parameters["@elExtra2"].SourceColumn = "EL_Extra2";
		dbCommand.Parameters["@elDate"].SourceColumn = "EL_Date";
		dbCommand.Parameters["@elStatus"].SourceColumn = "EL_Status";
		
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
	public static void Delete(System.Int64? elEbillID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID);
		
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
	public static void Delete(System.Int64? elEbillID)
	{
		Delete(
		elEbillID);
	}
	
	/// <summary>
	/// Delete current TMSElectricity from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ElEbillID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ElEbillID = null;
	}
	
	/// <summary>
	/// Delete current TMSElectricity from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSElectricity[] Search(System.Int64? elEbillID, System.Double? elBillAmount, System.Double? elLateFees, System.String elMonth, System.String elYear, System.DateTime? elLastDate, System.DateTime? elBillPaidDate, System.Double? elTotalAmount, System.String elPaidStatus, System.String elbIllno, System.String elBillFile, System.String elExtra1, System.String elExtra2, System.DateTime? elDate, System.Int32? elStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSElectricity_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, elEbillID, elBillAmount, elLateFees, elMonth, elYear, elLastDate, elBillPaidDate, elTotalAmount, elPaidStatus, elbIllno, elBillFile, elExtra1, elExtra2, elDate, elStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSElectricity.MapFrom(ds);
	}
	
	
	public static TMSElectricity[] Search(TMSElectricity searchObject)
	{
		return Search ( searchObject.ElEbillID, searchObject.ELBillAmount, searchObject.ELLateFees, searchObject.ELMonth, searchObject.ElYear, searchObject.ElLastDate, searchObject.ElBillPaidDate, searchObject.ELTotalAmount, searchObject.ELPaidStatus, searchObject.ELBIllno, searchObject.ELBillFile, searchObject.ELExtra1, searchObject.ELExtra2, searchObject.ELDate, searchObject.ELStatus);
	}
	
	/// <summary>
	/// Returns all TMSElectricity objects.
	/// </summary>
	/// <returns>List of all TMSElectricity objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSElectricity[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

