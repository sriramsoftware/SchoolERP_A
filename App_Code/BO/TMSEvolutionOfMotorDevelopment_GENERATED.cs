/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/5/2012 12:57:08 PM                                    */
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
public partial class TMSEvolutionOfMotorDevelopment
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfMotorDevelopment]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _emdDevelopmentId;
	private System.Int64? _emdSchoolId;
	private System.Int64? _emdSchoolSubId;
	private System.Int64? _emdStudentLoginId;
	private System.String _emdAlertandRemeber;
	private System.String _emdKickThrowBall;
	private System.String _emdHopJumpRun;
	private System.String _emdKeenObserver;
	private System.String _emdCommunicateClearly;
	private System.String _emdGripWithPencil;
	private System.String _emdMyBalanceHandEye;
	private System.String _emdPicesOfPuzzle;
	private System.String _emdAddedByType;
	private System.Int64? _emdAddedByLoginId;
	private System.DateTime? _emdDate;
	private System.Int32? _emdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? EMDDevelopmentId
	{
		get
		{
			return _emdDevelopmentId;
		}
		set
		{
			_emdDevelopmentId = value;
		}
	}
	
	public System.Int64? EMDSchoolId
	{
		get
		{
			return _emdSchoolId;
		}
		set
		{
			_emdSchoolId = value;
		}
	}
	
	public System.Int64? EMDSchoolSubId
	{
		get
		{
			return _emdSchoolSubId;
		}
		set
		{
			_emdSchoolSubId = value;
		}
	}
	
	public System.Int64? EMDStudentLoginId
	{
		get
		{
			return _emdStudentLoginId;
		}
		set
		{
			_emdStudentLoginId = value;
		}
	}
	
	public System.String EMDAlertandRemeber
	{
		get
		{
			return _emdAlertandRemeber;
		}
		set
		{
			_emdAlertandRemeber = value;
		}
	}
	
	public System.String EMDKickThrowBall
	{
		get
		{
			return _emdKickThrowBall;
		}
		set
		{
			_emdKickThrowBall = value;
		}
	}
	
	public System.String EMDHopJumpRun
	{
		get
		{
			return _emdHopJumpRun;
		}
		set
		{
			_emdHopJumpRun = value;
		}
	}
	
	public System.String EMDKeenObserver
	{
		get
		{
			return _emdKeenObserver;
		}
		set
		{
			_emdKeenObserver = value;
		}
	}
	
	public System.String EMDCommunicateClearly
	{
		get
		{
			return _emdCommunicateClearly;
		}
		set
		{
			_emdCommunicateClearly = value;
		}
	}
	
	public System.String EMDGripWithPencil
	{
		get
		{
			return _emdGripWithPencil;
		}
		set
		{
			_emdGripWithPencil = value;
		}
	}
	
	public System.String EMDMyBalanceHandEye
	{
		get
		{
			return _emdMyBalanceHandEye;
		}
		set
		{
			_emdMyBalanceHandEye = value;
		}
	}
	
	public System.String EMDPicesOfPuzzle
	{
		get
		{
			return _emdPicesOfPuzzle;
		}
		set
		{
			_emdPicesOfPuzzle = value;
		}
	}
	
	public System.String EMDAddedByType
	{
		get
		{
			return _emdAddedByType;
		}
		set
		{
			_emdAddedByType = value;
		}
	}
	
	public System.Int64? EMDAddedByLoginId
	{
		get
		{
			return _emdAddedByLoginId;
		}
		set
		{
			_emdAddedByLoginId = value;
		}
	}
	
	public System.DateTime? EMDDate
	{
		get
		{
			return _emdDate;
		}
		set
		{
			_emdDate = value;
		}
	}
	
	public System.Int32? EMDStatus
	{
		get
		{
			return _emdStatus;
		}
		set
		{
			_emdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("EMD_DevelopmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_AlertandRemeber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_KickThrowBall", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_HopJumpRun", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_KeenObserver", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_CommunicateClearly", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_GripWithPencil", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_MyBalanceHandEye", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_PicesOfPuzzle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EMD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EMDDevelopmentId == null)
		dr["EMD_DevelopmentId"] = DBNull.Value;
		else
		dr["EMD_DevelopmentId"] = EMDDevelopmentId;
		
		if (EMDSchoolId == null)
		dr["EMD_SchoolId"] = DBNull.Value;
		else
		dr["EMD_SchoolId"] = EMDSchoolId;
		
		if (EMDSchoolSubId == null)
		dr["EMD_SchoolSubId"] = DBNull.Value;
		else
		dr["EMD_SchoolSubId"] = EMDSchoolSubId;
		
		if (EMDStudentLoginId == null)
		dr["EMD_StudentLoginId"] = DBNull.Value;
		else
		dr["EMD_StudentLoginId"] = EMDStudentLoginId;
		
		if (EMDAlertandRemeber == null)
		dr["EMD_AlertandRemeber"] = DBNull.Value;
		else
		dr["EMD_AlertandRemeber"] = EMDAlertandRemeber;
		
		if (EMDKickThrowBall == null)
		dr["EMD_KickThrowBall"] = DBNull.Value;
		else
		dr["EMD_KickThrowBall"] = EMDKickThrowBall;
		
		if (EMDHopJumpRun == null)
		dr["EMD_HopJumpRun"] = DBNull.Value;
		else
		dr["EMD_HopJumpRun"] = EMDHopJumpRun;
		
		if (EMDKeenObserver == null)
		dr["EMD_KeenObserver"] = DBNull.Value;
		else
		dr["EMD_KeenObserver"] = EMDKeenObserver;
		
		if (EMDCommunicateClearly == null)
		dr["EMD_CommunicateClearly"] = DBNull.Value;
		else
		dr["EMD_CommunicateClearly"] = EMDCommunicateClearly;
		
		if (EMDGripWithPencil == null)
		dr["EMD_GripWithPencil"] = DBNull.Value;
		else
		dr["EMD_GripWithPencil"] = EMDGripWithPencil;
		
		if (EMDMyBalanceHandEye == null)
		dr["EMD_MyBalanceHandEye"] = DBNull.Value;
		else
		dr["EMD_MyBalanceHandEye"] = EMDMyBalanceHandEye;
		
		if (EMDPicesOfPuzzle == null)
		dr["EMD_PicesOfPuzzle"] = DBNull.Value;
		else
		dr["EMD_PicesOfPuzzle"] = EMDPicesOfPuzzle;
		
		if (EMDAddedByType == null)
		dr["EMD_AddedByType"] = DBNull.Value;
		else
		dr["EMD_AddedByType"] = EMDAddedByType;
		
		if (EMDAddedByLoginId == null)
		dr["EMD_AddedByLoginId"] = DBNull.Value;
		else
		dr["EMD_AddedByLoginId"] = EMDAddedByLoginId;
		
		if (EMDDate == null)
		dr["EMD_Date"] = DBNull.Value;
		else
		dr["EMD_Date"] = EMDDate;
		
		if (EMDStatus == null)
		dr["EMD_Status"] = DBNull.Value;
		else
		dr["EMD_Status"] = EMDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EMDDevelopmentId = dr["EMD_DevelopmentId"] != DBNull.Value ? Convert.ToInt64(dr["EMD_DevelopmentId"]) : EMDDevelopmentId = null;
		EMDSchoolId = dr["EMD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["EMD_SchoolId"]) : EMDSchoolId = null;
		EMDSchoolSubId = dr["EMD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["EMD_SchoolSubId"]) : EMDSchoolSubId = null;
		EMDStudentLoginId = dr["EMD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EMD_StudentLoginId"]) : EMDStudentLoginId = null;
		EMDAlertandRemeber = dr["EMD_AlertandRemeber"] != DBNull.Value ? Convert.ToString(dr["EMD_AlertandRemeber"]) : EMDAlertandRemeber = null;
		EMDKickThrowBall = dr["EMD_KickThrowBall"] != DBNull.Value ? Convert.ToString(dr["EMD_KickThrowBall"]) : EMDKickThrowBall = null;
		EMDHopJumpRun = dr["EMD_HopJumpRun"] != DBNull.Value ? Convert.ToString(dr["EMD_HopJumpRun"]) : EMDHopJumpRun = null;
		EMDKeenObserver = dr["EMD_KeenObserver"] != DBNull.Value ? Convert.ToString(dr["EMD_KeenObserver"]) : EMDKeenObserver = null;
		EMDCommunicateClearly = dr["EMD_CommunicateClearly"] != DBNull.Value ? Convert.ToString(dr["EMD_CommunicateClearly"]) : EMDCommunicateClearly = null;
		EMDGripWithPencil = dr["EMD_GripWithPencil"] != DBNull.Value ? Convert.ToString(dr["EMD_GripWithPencil"]) : EMDGripWithPencil = null;
		EMDMyBalanceHandEye = dr["EMD_MyBalanceHandEye"] != DBNull.Value ? Convert.ToString(dr["EMD_MyBalanceHandEye"]) : EMDMyBalanceHandEye = null;
		EMDPicesOfPuzzle = dr["EMD_PicesOfPuzzle"] != DBNull.Value ? Convert.ToString(dr["EMD_PicesOfPuzzle"]) : EMDPicesOfPuzzle = null;
		EMDAddedByType = dr["EMD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["EMD_AddedByType"]) : EMDAddedByType = null;
		EMDAddedByLoginId = dr["EMD_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EMD_AddedByLoginId"]) : EMDAddedByLoginId = null;
		EMDDate = dr["EMD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EMD_Date"]) : EMDDate = null;
		EMDStatus = dr["EMD_Status"] != DBNull.Value ? Convert.ToInt32(dr["EMD_Status"]) : EMDStatus = null;
	}
	
	public static TMSEvolutionOfMotorDevelopment[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfMotorDevelopment> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfMotorDevelopment>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfMotorDevelopment] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfMotorDevelopment] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfMotorDevelopment instance = new TMSEvolutionOfMotorDevelopment();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfMotorDevelopment Get(System.Int64 emdDevelopmentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfMotorDevelopment instance;
		
		
		instance = new TMSEvolutionOfMotorDevelopment();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emdDevelopmentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfMotorDevelopment ID:" + emdDevelopmentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emdSchoolId, emdSchoolSubId, emdStudentLoginId, emdAlertandRemeber, emdKickThrowBall, emdHopJumpRun, emdKeenObserver, emdCommunicateClearly, emdGripWithPencil, emdMyBalanceHandEye, emdPicesOfPuzzle, emdAddedByType, emdAddedByLoginId, emdDate, emdStatus);
		
		if (transaction == null)
		this.EMDDevelopmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.EMDDevelopmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus)
	{
		Insert(emdSchoolId, emdSchoolSubId, emdStudentLoginId, emdAlertandRemeber, emdKickThrowBall, emdHopJumpRun, emdKeenObserver, emdCommunicateClearly, emdGripWithPencil, emdMyBalanceHandEye, emdPicesOfPuzzle, emdAddedByType, emdAddedByLoginId, emdDate, emdStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfMotorDevelopment to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EMDSchoolId, EMDSchoolSubId, EMDStudentLoginId, EMDAlertandRemeber, EMDKickThrowBall, EMDHopJumpRun, EMDKeenObserver, EMDCommunicateClearly, EMDGripWithPencil, EMDMyBalanceHandEye, EMDPicesOfPuzzle, EMDAddedByType, EMDAddedByLoginId, EMDDate, EMDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfMotorDevelopment to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? emdDevelopmentId, System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@emdDevelopmentId"].Value = emdDevelopmentId;
		dbCommand.Parameters["@emdSchoolId"].Value = emdSchoolId;
		dbCommand.Parameters["@emdSchoolSubId"].Value = emdSchoolSubId;
		dbCommand.Parameters["@emdStudentLoginId"].Value = emdStudentLoginId;
		dbCommand.Parameters["@emdAlertandRemeber"].Value = emdAlertandRemeber;
		dbCommand.Parameters["@emdKickThrowBall"].Value = emdKickThrowBall;
		dbCommand.Parameters["@emdHopJumpRun"].Value = emdHopJumpRun;
		dbCommand.Parameters["@emdKeenObserver"].Value = emdKeenObserver;
		dbCommand.Parameters["@emdCommunicateClearly"].Value = emdCommunicateClearly;
		dbCommand.Parameters["@emdGripWithPencil"].Value = emdGripWithPencil;
		dbCommand.Parameters["@emdMyBalanceHandEye"].Value = emdMyBalanceHandEye;
		dbCommand.Parameters["@emdPicesOfPuzzle"].Value = emdPicesOfPuzzle;
		dbCommand.Parameters["@emdAddedByType"].Value = emdAddedByType;
		dbCommand.Parameters["@emdAddedByLoginId"].Value = emdAddedByLoginId;
		dbCommand.Parameters["@emdDate"].Value = emdDate;
		dbCommand.Parameters["@emdStatus"].Value = emdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? emdDevelopmentId, System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus)
	{
		Update(emdDevelopmentId, emdSchoolId, emdSchoolSubId, emdStudentLoginId, emdAlertandRemeber, emdKickThrowBall, emdHopJumpRun, emdKeenObserver, emdCommunicateClearly, emdGripWithPencil, emdMyBalanceHandEye, emdPicesOfPuzzle, emdAddedByType, emdAddedByLoginId, emdDate, emdStatus, null);
	}
	
	public static void Update(TMSEvolutionOfMotorDevelopment tMSEvolutionOfMotorDevelopment)
	{
		tMSEvolutionOfMotorDevelopment.Update();
	}
	
	public static void Update(TMSEvolutionOfMotorDevelopment tMSEvolutionOfMotorDevelopment, DbTransaction transaction)
	{
		tMSEvolutionOfMotorDevelopment.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@emdDevelopmentId"].SourceColumn = "EMD_DevelopmentId";
		dbCommand.Parameters["@emdSchoolId"].SourceColumn = "EMD_SchoolId";
		dbCommand.Parameters["@emdSchoolSubId"].SourceColumn = "EMD_SchoolSubId";
		dbCommand.Parameters["@emdStudentLoginId"].SourceColumn = "EMD_StudentLoginId";
		dbCommand.Parameters["@emdAlertandRemeber"].SourceColumn = "EMD_AlertandRemeber";
		dbCommand.Parameters["@emdKickThrowBall"].SourceColumn = "EMD_KickThrowBall";
		dbCommand.Parameters["@emdHopJumpRun"].SourceColumn = "EMD_HopJumpRun";
		dbCommand.Parameters["@emdKeenObserver"].SourceColumn = "EMD_KeenObserver";
		dbCommand.Parameters["@emdCommunicateClearly"].SourceColumn = "EMD_CommunicateClearly";
		dbCommand.Parameters["@emdGripWithPencil"].SourceColumn = "EMD_GripWithPencil";
		dbCommand.Parameters["@emdMyBalanceHandEye"].SourceColumn = "EMD_MyBalanceHandEye";
		dbCommand.Parameters["@emdPicesOfPuzzle"].SourceColumn = "EMD_PicesOfPuzzle";
		dbCommand.Parameters["@emdAddedByType"].SourceColumn = "EMD_AddedByType";
		dbCommand.Parameters["@emdAddedByLoginId"].SourceColumn = "EMD_AddedByLoginId";
		dbCommand.Parameters["@emdDate"].SourceColumn = "EMD_Date";
		dbCommand.Parameters["@emdStatus"].SourceColumn = "EMD_Status";
		
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
	public static void Delete(System.Int64? emdDevelopmentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emdDevelopmentId);
		
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
	public static void Delete(System.Int64? emdDevelopmentId)
	{
		Delete(
		emdDevelopmentId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfMotorDevelopment from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EMDDevelopmentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EMDDevelopmentId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfMotorDevelopment from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfMotorDevelopment[] Search(System.Int64? emdDevelopmentId, System.Int64? emdSchoolId, System.Int64? emdSchoolSubId, System.Int64? emdStudentLoginId, System.String emdAlertandRemeber, System.String emdKickThrowBall, System.String emdHopJumpRun, System.String emdKeenObserver, System.String emdCommunicateClearly, System.String emdGripWithPencil, System.String emdMyBalanceHandEye, System.String emdPicesOfPuzzle, System.String emdAddedByType, System.Int64? emdAddedByLoginId, System.DateTime? emdDate, System.Int32? emdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfMotorDevelopment_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, emdDevelopmentId, emdSchoolId, emdSchoolSubId, emdStudentLoginId, emdAlertandRemeber, emdKickThrowBall, emdHopJumpRun, emdKeenObserver, emdCommunicateClearly, emdGripWithPencil, emdMyBalanceHandEye, emdPicesOfPuzzle, emdAddedByType, emdAddedByLoginId, emdDate, emdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfMotorDevelopment.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfMotorDevelopment[] Search(TMSEvolutionOfMotorDevelopment searchObject)
	{
		return Search ( searchObject.EMDDevelopmentId, searchObject.EMDSchoolId, searchObject.EMDSchoolSubId, searchObject.EMDStudentLoginId, searchObject.EMDAlertandRemeber, searchObject.EMDKickThrowBall, searchObject.EMDHopJumpRun, searchObject.EMDKeenObserver, searchObject.EMDCommunicateClearly, searchObject.EMDGripWithPencil, searchObject.EMDMyBalanceHandEye, searchObject.EMDPicesOfPuzzle, searchObject.EMDAddedByType, searchObject.EMDAddedByLoginId, searchObject.EMDDate, searchObject.EMDStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfMotorDevelopment objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfMotorDevelopment objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfMotorDevelopment[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

