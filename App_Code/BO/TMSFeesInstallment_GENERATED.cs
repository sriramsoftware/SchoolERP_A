/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/6/2012 10:58:09 AM                                    */
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
public partial class TMSFeesInstallment
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesInstallment]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fiInstallmentId;
	private System.Int64? _fiStudentLoginId;
	private System.Int64? _fiSchoolId;
	private System.Int64? _fiSchoolSubId;
	private System.Int64? _fiPaymentId;
	private System.String _fiInstallmentType;
	private System.String _fiAmount;
	private System.String _fiInstallmentStatus;
	private System.DateTime? _fiLastDate;
	private System.String _fiLateFeesPerDay;
	private System.String _fiTotalFees;
	private System.DateTime? _fiDate;
	private System.Int32? _fiStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FIInstallmentId
	{
		get
		{
			return _fiInstallmentId;
		}
		set
		{
			_fiInstallmentId = value;
		}
	}
	
	public System.Int64? FIStudentLoginId
	{
		get
		{
			return _fiStudentLoginId;
		}
		set
		{
			_fiStudentLoginId = value;
		}
	}
	
	public System.Int64? FISchoolId
	{
		get
		{
			return _fiSchoolId;
		}
		set
		{
			_fiSchoolId = value;
		}
	}
	
	public System.Int64? FISchoolSubId
	{
		get
		{
			return _fiSchoolSubId;
		}
		set
		{
			_fiSchoolSubId = value;
		}
	}
	
	public System.Int64? FIPaymentId
	{
		get
		{
			return _fiPaymentId;
		}
		set
		{
			_fiPaymentId = value;
		}
	}
	
	public System.String FIInstallmentType
	{
		get
		{
			return _fiInstallmentType;
		}
		set
		{
			_fiInstallmentType = value;
		}
	}
	
	public System.String FIAmount
	{
		get
		{
			return _fiAmount;
		}
		set
		{
			_fiAmount = value;
		}
	}
	
	public System.String FIInstallmentStatus
	{
		get
		{
			return _fiInstallmentStatus;
		}
		set
		{
			_fiInstallmentStatus = value;
		}
	}
	
	public System.DateTime? FILastDate
	{
		get
		{
			return _fiLastDate;
		}
		set
		{
			_fiLastDate = value;
		}
	}
	
	public System.String FILateFeesPerDay
	{
		get
		{
			return _fiLateFeesPerDay;
		}
		set
		{
			_fiLateFeesPerDay = value;
		}
	}
	
	public System.String FITotalFees
	{
		get
		{
			return _fiTotalFees;
		}
		set
		{
			_fiTotalFees = value;
		}
	}
	
	public System.DateTime? FIDate
	{
		get
		{
			return _fiDate;
		}
		set
		{
			_fiDate = value;
		}
	}
	
	public System.Int32? FIStatus
	{
		get
		{
			return _fiStatus;
		}
		set
		{
			_fiStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FI_InstallmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_PaymentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_InstallmentType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_Amount", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_InstallmentStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_LastDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_LateFeesPerDay", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_TotalFees", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FI_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FIInstallmentId == null)
		dr["FI_InstallmentId"] = DBNull.Value;
		else
		dr["FI_InstallmentId"] = FIInstallmentId;
		
		if (FIStudentLoginId == null)
		dr["FI_StudentLoginId"] = DBNull.Value;
		else
		dr["FI_StudentLoginId"] = FIStudentLoginId;
		
		if (FISchoolId == null)
		dr["FI_SchoolId"] = DBNull.Value;
		else
		dr["FI_SchoolId"] = FISchoolId;
		
		if (FISchoolSubId == null)
		dr["FI_SchoolSubId"] = DBNull.Value;
		else
		dr["FI_SchoolSubId"] = FISchoolSubId;
		
		if (FIPaymentId == null)
		dr["FI_PaymentId"] = DBNull.Value;
		else
		dr["FI_PaymentId"] = FIPaymentId;
		
		if (FIInstallmentType == null)
		dr["FI_InstallmentType"] = DBNull.Value;
		else
		dr["FI_InstallmentType"] = FIInstallmentType;
		
		if (FIAmount == null)
		dr["FI_Amount"] = DBNull.Value;
		else
		dr["FI_Amount"] = FIAmount;
		
		if (FIInstallmentStatus == null)
		dr["FI_InstallmentStatus"] = DBNull.Value;
		else
		dr["FI_InstallmentStatus"] = FIInstallmentStatus;
		
		if (FILastDate == null)
		dr["FI_LastDate"] = DBNull.Value;
		else
		dr["FI_LastDate"] = FILastDate;
		
		if (FILateFeesPerDay == null)
		dr["FI_LateFeesPerDay"] = DBNull.Value;
		else
		dr["FI_LateFeesPerDay"] = FILateFeesPerDay;
		
		if (FITotalFees == null)
		dr["FI_TotalFees"] = DBNull.Value;
		else
		dr["FI_TotalFees"] = FITotalFees;
		
		if (FIDate == null)
		dr["FI_Date"] = DBNull.Value;
		else
		dr["FI_Date"] = FIDate;
		
		if (FIStatus == null)
		dr["FI_Status"] = DBNull.Value;
		else
		dr["FI_Status"] = FIStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FIInstallmentId = dr["FI_InstallmentId"] != DBNull.Value ? Convert.ToInt64(dr["FI_InstallmentId"]) : FIInstallmentId = null;
		FIStudentLoginId = dr["FI_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["FI_StudentLoginId"]) : FIStudentLoginId = null;
		FISchoolId = dr["FI_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["FI_SchoolId"]) : FISchoolId = null;
		FISchoolSubId = dr["FI_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["FI_SchoolSubId"]) : FISchoolSubId = null;
		FIPaymentId = dr["FI_PaymentId"] != DBNull.Value ? Convert.ToInt64(dr["FI_PaymentId"]) : FIPaymentId = null;
		FIInstallmentType = dr["FI_InstallmentType"] != DBNull.Value ? Convert.ToString(dr["FI_InstallmentType"]) : FIInstallmentType = null;
		FIAmount = dr["FI_Amount"] != DBNull.Value ? Convert.ToString(dr["FI_Amount"]) : FIAmount = null;
		FIInstallmentStatus = dr["FI_InstallmentStatus"] != DBNull.Value ? Convert.ToString(dr["FI_InstallmentStatus"]) : FIInstallmentStatus = null;
		FILastDate = dr["FI_LastDate"] != DBNull.Value ? Convert.ToDateTime(dr["FI_LastDate"]) : FILastDate = null;
		FILateFeesPerDay = dr["FI_LateFeesPerDay"] != DBNull.Value ? Convert.ToString(dr["FI_LateFeesPerDay"]) : FILateFeesPerDay = null;
		FITotalFees = dr["FI_TotalFees"] != DBNull.Value ? Convert.ToString(dr["FI_TotalFees"]) : FITotalFees = null;
		FIDate = dr["FI_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FI_Date"]) : FIDate = null;
		FIStatus = dr["FI_Status"] != DBNull.Value ? Convert.ToInt32(dr["FI_Status"]) : FIStatus = null;
	}
	
	public static TMSFeesInstallment[] MapFrom(DataSet ds)
	{
		List<TMSFeesInstallment> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesInstallment>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesInstallment] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesInstallment] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesInstallment instance = new TMSFeesInstallment();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesInstallment Get(System.Int64 fiInstallmentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesInstallment instance;
		
		
		instance = new TMSFeesInstallment();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fiInstallmentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesInstallment ID:" + fiInstallmentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fiStudentLoginId, fiSchoolId, fiSchoolSubId, fiPaymentId, fiInstallmentType, fiAmount, fiInstallmentStatus, fiLastDate, fiLateFeesPerDay, fiTotalFees, fiDate, fiStatus);
		
		if (transaction == null)
		this.FIInstallmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FIInstallmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus)
	{
		Insert(fiStudentLoginId, fiSchoolId, fiSchoolSubId, fiPaymentId, fiInstallmentType, fiAmount, fiInstallmentStatus, fiLastDate, fiLateFeesPerDay, fiTotalFees, fiDate, fiStatus, null);
	}
	/// <summary>
	/// Insert current TMSFeesInstallment to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FIStudentLoginId, FISchoolId, FISchoolSubId, FIPaymentId, FIInstallmentType, FIAmount, FIInstallmentStatus, FILastDate, FILateFeesPerDay, FITotalFees, FIDate, FIStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesInstallment to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fiInstallmentId, System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fiInstallmentId"].Value = fiInstallmentId;
		dbCommand.Parameters["@fiStudentLoginId"].Value = fiStudentLoginId;
		dbCommand.Parameters["@fiSchoolId"].Value = fiSchoolId;
		dbCommand.Parameters["@fiSchoolSubId"].Value = fiSchoolSubId;
		dbCommand.Parameters["@fiPaymentId"].Value = fiPaymentId;
		dbCommand.Parameters["@fiInstallmentType"].Value = fiInstallmentType;
		dbCommand.Parameters["@fiAmount"].Value = fiAmount;
		dbCommand.Parameters["@fiInstallmentStatus"].Value = fiInstallmentStatus;
		dbCommand.Parameters["@fiLastDate"].Value = fiLastDate;
		dbCommand.Parameters["@fiLateFeesPerDay"].Value = fiLateFeesPerDay;
		dbCommand.Parameters["@fiTotalFees"].Value = fiTotalFees;
		dbCommand.Parameters["@fiDate"].Value = fiDate;
		dbCommand.Parameters["@fiStatus"].Value = fiStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fiInstallmentId, System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus)
	{
		Update(fiInstallmentId, fiStudentLoginId, fiSchoolId, fiSchoolSubId, fiPaymentId, fiInstallmentType, fiAmount, fiInstallmentStatus, fiLastDate, fiLateFeesPerDay, fiTotalFees, fiDate, fiStatus, null);
	}
	
	public static void Update(TMSFeesInstallment tMSFeesInstallment)
	{
		tMSFeesInstallment.Update();
	}
	
	public static void Update(TMSFeesInstallment tMSFeesInstallment, DbTransaction transaction)
	{
		tMSFeesInstallment.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesInstallment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fiInstallmentId"].SourceColumn = "FI_InstallmentId";
		dbCommand.Parameters["@fiStudentLoginId"].SourceColumn = "FI_StudentLoginId";
		dbCommand.Parameters["@fiSchoolId"].SourceColumn = "FI_SchoolId";
		dbCommand.Parameters["@fiSchoolSubId"].SourceColumn = "FI_SchoolSubId";
		dbCommand.Parameters["@fiPaymentId"].SourceColumn = "FI_PaymentId";
		dbCommand.Parameters["@fiInstallmentType"].SourceColumn = "FI_InstallmentType";
		dbCommand.Parameters["@fiAmount"].SourceColumn = "FI_Amount";
		dbCommand.Parameters["@fiInstallmentStatus"].SourceColumn = "FI_InstallmentStatus";
		dbCommand.Parameters["@fiLastDate"].SourceColumn = "FI_LastDate";
		dbCommand.Parameters["@fiLateFeesPerDay"].SourceColumn = "FI_LateFeesPerDay";
		dbCommand.Parameters["@fiTotalFees"].SourceColumn = "FI_TotalFees";
		dbCommand.Parameters["@fiDate"].SourceColumn = "FI_Date";
		dbCommand.Parameters["@fiStatus"].SourceColumn = "FI_Status";
		
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
	public static void Delete(System.Int64? fiInstallmentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fiInstallmentId);
		
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
	public static void Delete(System.Int64? fiInstallmentId)
	{
		Delete(
		fiInstallmentId);
	}
	
	/// <summary>
	/// Delete current TMSFeesInstallment from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FIInstallmentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FIInstallmentId = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesInstallment from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesInstallment[] Search(System.Int64? fiInstallmentId, System.Int64? fiStudentLoginId, System.Int64? fiSchoolId, System.Int64? fiSchoolSubId, System.Int64? fiPaymentId, System.String fiInstallmentType, System.String fiAmount, System.String fiInstallmentStatus, System.DateTime? fiLastDate, System.String fiLateFeesPerDay, System.String fiTotalFees, System.DateTime? fiDate, System.Int32? fiStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesInstallment_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fiInstallmentId, fiStudentLoginId, fiSchoolId, fiSchoolSubId, fiPaymentId, fiInstallmentType, fiAmount, fiInstallmentStatus, fiLastDate, fiLateFeesPerDay, fiTotalFees, fiDate, fiStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesInstallment.MapFrom(ds);
	}
	
	
	public static TMSFeesInstallment[] Search(TMSFeesInstallment searchObject)
	{
		return Search ( searchObject.FIInstallmentId, searchObject.FIStudentLoginId, searchObject.FISchoolId, searchObject.FISchoolSubId, searchObject.FIPaymentId, searchObject.FIInstallmentType, searchObject.FIAmount, searchObject.FIInstallmentStatus, searchObject.FILastDate, searchObject.FILateFeesPerDay, searchObject.FITotalFees, searchObject.FIDate, searchObject.FIStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeesInstallment objects.
	/// </summary>
	/// <returns>List of all TMSFeesInstallment objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesInstallment[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

