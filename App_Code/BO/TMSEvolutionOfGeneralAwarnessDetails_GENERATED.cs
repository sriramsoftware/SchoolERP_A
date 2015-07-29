/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/4/2012 2:35:45 PM                                    */
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
public partial class TMSEvolutionOfGeneralAwarnessDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfGeneralAwarnessDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _egadAwarnessId;
	private System.Int64? _egadSchoolId;
	private System.Int64? _egadSchoolSubId;
	private System.Int64? _egadStudentLoginId;
	private System.String _egadMySurrounding;
	private System.String _egadMyMotherName;
	private System.String _egadMyFatherName;
	private System.String _egadMyHomeAddress;
	private System.String _egadMyPhoneNumber;
	private System.String _egadMySchoolName;
	private System.String _egadAddedByType;
	private System.Int64? _egadAddedByLoginId;
	private System.DateTime? _egadDate;
	private System.Int32? _egadStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? EGADAwarnessId
	{
		get
		{
			return _egadAwarnessId;
		}
		set
		{
			_egadAwarnessId = value;
		}
	}
	
	public System.Int64? EGADSchoolId
	{
		get
		{
			return _egadSchoolId;
		}
		set
		{
			_egadSchoolId = value;
		}
	}
	
	public System.Int64? EGADSchoolSubId
	{
		get
		{
			return _egadSchoolSubId;
		}
		set
		{
			_egadSchoolSubId = value;
		}
	}
	
	public System.Int64? EGADStudentLoginId
	{
		get
		{
			return _egadStudentLoginId;
		}
		set
		{
			_egadStudentLoginId = value;
		}
	}
	
	public System.String EGADMySurrounding
	{
		get
		{
			return _egadMySurrounding;
		}
		set
		{
			_egadMySurrounding = value;
		}
	}
	
	public System.String EGADMyMotherName
	{
		get
		{
			return _egadMyMotherName;
		}
		set
		{
			_egadMyMotherName = value;
		}
	}
	
	public System.String EGADMyFatherName
	{
		get
		{
			return _egadMyFatherName;
		}
		set
		{
			_egadMyFatherName = value;
		}
	}
	
	public System.String EGADMyHomeAddress
	{
		get
		{
			return _egadMyHomeAddress;
		}
		set
		{
			_egadMyHomeAddress = value;
		}
	}
	
	public System.String EGADMyPhoneNumber
	{
		get
		{
			return _egadMyPhoneNumber;
		}
		set
		{
			_egadMyPhoneNumber = value;
		}
	}
	
	public System.String EGADMySchoolName
	{
		get
		{
			return _egadMySchoolName;
		}
		set
		{
			_egadMySchoolName = value;
		}
	}
	
	public System.String EGADAddedByType
	{
		get
		{
			return _egadAddedByType;
		}
		set
		{
			_egadAddedByType = value;
		}
	}
	
	public System.Int64? EGADAddedByLoginId
	{
		get
		{
			return _egadAddedByLoginId;
		}
		set
		{
			_egadAddedByLoginId = value;
		}
	}
	
	public System.DateTime? EGADDate
	{
		get
		{
			return _egadDate;
		}
		set
		{
			_egadDate = value;
		}
	}
	
	public System.Int32? EGADStatus
	{
		get
		{
			return _egadStatus;
		}
		set
		{
			_egadStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_AwarnessId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MySurrounding", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MyMotherName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MyFatherName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MyHomeAddress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MyPhoneNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_MySchoolName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EGAD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EGADAwarnessId == null)
		dr["EGAD_AwarnessId"] = DBNull.Value;
		else
		dr["EGAD_AwarnessId"] = EGADAwarnessId;
		
		if (EGADSchoolId == null)
		dr["EGAD_SchoolId"] = DBNull.Value;
		else
		dr["EGAD_SchoolId"] = EGADSchoolId;
		
		if (EGADSchoolSubId == null)
		dr["EGAD_SchoolSubId"] = DBNull.Value;
		else
		dr["EGAD_SchoolSubId"] = EGADSchoolSubId;
		
		if (EGADStudentLoginId == null)
		dr["EGAD_StudentLoginId"] = DBNull.Value;
		else
		dr["EGAD_StudentLoginId"] = EGADStudentLoginId;
		
		if (EGADMySurrounding == null)
		dr["EGAD_MySurrounding"] = DBNull.Value;
		else
		dr["EGAD_MySurrounding"] = EGADMySurrounding;
		
		if (EGADMyMotherName == null)
		dr["EGAD_MyMotherName"] = DBNull.Value;
		else
		dr["EGAD_MyMotherName"] = EGADMyMotherName;
		
		if (EGADMyFatherName == null)
		dr["EGAD_MyFatherName"] = DBNull.Value;
		else
		dr["EGAD_MyFatherName"] = EGADMyFatherName;
		
		if (EGADMyHomeAddress == null)
		dr["EGAD_MyHomeAddress"] = DBNull.Value;
		else
		dr["EGAD_MyHomeAddress"] = EGADMyHomeAddress;
		
		if (EGADMyPhoneNumber == null)
		dr["EGAD_MyPhoneNumber"] = DBNull.Value;
		else
		dr["EGAD_MyPhoneNumber"] = EGADMyPhoneNumber;
		
		if (EGADMySchoolName == null)
		dr["EGAD_MySchoolName"] = DBNull.Value;
		else
		dr["EGAD_MySchoolName"] = EGADMySchoolName;
		
		if (EGADAddedByType == null)
		dr["EGAD_AddedByType"] = DBNull.Value;
		else
		dr["EGAD_AddedByType"] = EGADAddedByType;
		
		if (EGADAddedByLoginId == null)
		dr["EGAD_AddedByLoginId"] = DBNull.Value;
		else
		dr["EGAD_AddedByLoginId"] = EGADAddedByLoginId;
		
		if (EGADDate == null)
		dr["EGAD_Date"] = DBNull.Value;
		else
		dr["EGAD_Date"] = EGADDate;
		
		if (EGADStatus == null)
		dr["EGAD_Status"] = DBNull.Value;
		else
		dr["EGAD_Status"] = EGADStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EGADAwarnessId = dr["EGAD_AwarnessId"] != DBNull.Value ? Convert.ToInt64(dr["EGAD_AwarnessId"]) : EGADAwarnessId = null;
		EGADSchoolId = dr["EGAD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["EGAD_SchoolId"]) : EGADSchoolId = null;
		EGADSchoolSubId = dr["EGAD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["EGAD_SchoolSubId"]) : EGADSchoolSubId = null;
		EGADStudentLoginId = dr["EGAD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EGAD_StudentLoginId"]) : EGADStudentLoginId = null;
		EGADMySurrounding = dr["EGAD_MySurrounding"] != DBNull.Value ? Convert.ToString(dr["EGAD_MySurrounding"]) : EGADMySurrounding = null;
		EGADMyMotherName = dr["EGAD_MyMotherName"] != DBNull.Value ? Convert.ToString(dr["EGAD_MyMotherName"]) : EGADMyMotherName = null;
		EGADMyFatherName = dr["EGAD_MyFatherName"] != DBNull.Value ? Convert.ToString(dr["EGAD_MyFatherName"]) : EGADMyFatherName = null;
		EGADMyHomeAddress = dr["EGAD_MyHomeAddress"] != DBNull.Value ? Convert.ToString(dr["EGAD_MyHomeAddress"]) : EGADMyHomeAddress = null;
		EGADMyPhoneNumber = dr["EGAD_MyPhoneNumber"] != DBNull.Value ? Convert.ToString(dr["EGAD_MyPhoneNumber"]) : EGADMyPhoneNumber = null;
		EGADMySchoolName = dr["EGAD_MySchoolName"] != DBNull.Value ? Convert.ToString(dr["EGAD_MySchoolName"]) : EGADMySchoolName = null;
		EGADAddedByType = dr["EGAD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["EGAD_AddedByType"]) : EGADAddedByType = null;
		EGADAddedByLoginId = dr["EGAD_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EGAD_AddedByLoginId"]) : EGADAddedByLoginId = null;
		EGADDate = dr["EGAD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EGAD_Date"]) : EGADDate = null;
		EGADStatus = dr["EGAD_Status"] != DBNull.Value ? Convert.ToInt32(dr["EGAD_Status"]) : EGADStatus = null;
	}
	
	public static TMSEvolutionOfGeneralAwarnessDetails[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfGeneralAwarnessDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfGeneralAwarnessDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfGeneralAwarnessDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfGeneralAwarnessDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfGeneralAwarnessDetails instance = new TMSEvolutionOfGeneralAwarnessDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfGeneralAwarnessDetails Get(System.Int64 egadAwarnessId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfGeneralAwarnessDetails instance;
		
		
		instance = new TMSEvolutionOfGeneralAwarnessDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egadAwarnessId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfGeneralAwarnessDetails ID:" + egadAwarnessId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egadSchoolId, egadSchoolSubId, egadStudentLoginId, egadMySurrounding, egadMyMotherName, egadMyFatherName, egadMyHomeAddress, egadMyPhoneNumber, egadMySchoolName, egadAddedByType, egadAddedByLoginId, egadDate, egadStatus);
		
		if (transaction == null)
		this.EGADAwarnessId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.EGADAwarnessId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus)
	{
		Insert(egadSchoolId, egadSchoolSubId, egadStudentLoginId, egadMySurrounding, egadMyMotherName, egadMyFatherName, egadMyHomeAddress, egadMyPhoneNumber, egadMySchoolName, egadAddedByType, egadAddedByLoginId, egadDate, egadStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfGeneralAwarnessDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EGADSchoolId, EGADSchoolSubId, EGADStudentLoginId, EGADMySurrounding, EGADMyMotherName, EGADMyFatherName, EGADMyHomeAddress, EGADMyPhoneNumber, EGADMySchoolName, EGADAddedByType, EGADAddedByLoginId, EGADDate, EGADStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfGeneralAwarnessDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? egadAwarnessId, System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@egadAwarnessId"].Value = egadAwarnessId;
		dbCommand.Parameters["@egadSchoolId"].Value = egadSchoolId;
		dbCommand.Parameters["@egadSchoolSubId"].Value = egadSchoolSubId;
		dbCommand.Parameters["@egadStudentLoginId"].Value = egadStudentLoginId;
		dbCommand.Parameters["@egadMySurrounding"].Value = egadMySurrounding;
		dbCommand.Parameters["@egadMyMotherName"].Value = egadMyMotherName;
		dbCommand.Parameters["@egadMyFatherName"].Value = egadMyFatherName;
		dbCommand.Parameters["@egadMyHomeAddress"].Value = egadMyHomeAddress;
		dbCommand.Parameters["@egadMyPhoneNumber"].Value = egadMyPhoneNumber;
		dbCommand.Parameters["@egadMySchoolName"].Value = egadMySchoolName;
		dbCommand.Parameters["@egadAddedByType"].Value = egadAddedByType;
		dbCommand.Parameters["@egadAddedByLoginId"].Value = egadAddedByLoginId;
		dbCommand.Parameters["@egadDate"].Value = egadDate;
		dbCommand.Parameters["@egadStatus"].Value = egadStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? egadAwarnessId, System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus)
	{
		Update(egadAwarnessId, egadSchoolId, egadSchoolSubId, egadStudentLoginId, egadMySurrounding, egadMyMotherName, egadMyFatherName, egadMyHomeAddress, egadMyPhoneNumber, egadMySchoolName, egadAddedByType, egadAddedByLoginId, egadDate, egadStatus, null);
	}
	
	public static void Update(TMSEvolutionOfGeneralAwarnessDetails tMSEvolutionOfGeneralAwarnessDetails)
	{
		tMSEvolutionOfGeneralAwarnessDetails.Update();
	}
	
	public static void Update(TMSEvolutionOfGeneralAwarnessDetails tMSEvolutionOfGeneralAwarnessDetails, DbTransaction transaction)
	{
		tMSEvolutionOfGeneralAwarnessDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@egadAwarnessId"].SourceColumn = "EGAD_AwarnessId";
		dbCommand.Parameters["@egadSchoolId"].SourceColumn = "EGAD_SchoolId";
		dbCommand.Parameters["@egadSchoolSubId"].SourceColumn = "EGAD_SchoolSubId";
		dbCommand.Parameters["@egadStudentLoginId"].SourceColumn = "EGAD_StudentLoginId";
		dbCommand.Parameters["@egadMySurrounding"].SourceColumn = "EGAD_MySurrounding";
		dbCommand.Parameters["@egadMyMotherName"].SourceColumn = "EGAD_MyMotherName";
		dbCommand.Parameters["@egadMyFatherName"].SourceColumn = "EGAD_MyFatherName";
		dbCommand.Parameters["@egadMyHomeAddress"].SourceColumn = "EGAD_MyHomeAddress";
		dbCommand.Parameters["@egadMyPhoneNumber"].SourceColumn = "EGAD_MyPhoneNumber";
		dbCommand.Parameters["@egadMySchoolName"].SourceColumn = "EGAD_MySchoolName";
		dbCommand.Parameters["@egadAddedByType"].SourceColumn = "EGAD_AddedByType";
		dbCommand.Parameters["@egadAddedByLoginId"].SourceColumn = "EGAD_AddedByLoginId";
		dbCommand.Parameters["@egadDate"].SourceColumn = "EGAD_Date";
		dbCommand.Parameters["@egadStatus"].SourceColumn = "EGAD_Status";
		
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
	public static void Delete(System.Int64? egadAwarnessId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egadAwarnessId);
		
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
	public static void Delete(System.Int64? egadAwarnessId)
	{
		Delete(
		egadAwarnessId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfGeneralAwarnessDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EGADAwarnessId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EGADAwarnessId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfGeneralAwarnessDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfGeneralAwarnessDetails[] Search(System.Int64? egadAwarnessId, System.Int64? egadSchoolId, System.Int64? egadSchoolSubId, System.Int64? egadStudentLoginId, System.String egadMySurrounding, System.String egadMyMotherName, System.String egadMyFatherName, System.String egadMyHomeAddress, System.String egadMyPhoneNumber, System.String egadMySchoolName, System.String egadAddedByType, System.Int64? egadAddedByLoginId, System.DateTime? egadDate, System.Int32? egadStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfGeneralAwarnessDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egadAwarnessId, egadSchoolId, egadSchoolSubId, egadStudentLoginId, egadMySurrounding, egadMyMotherName, egadMyFatherName, egadMyHomeAddress, egadMyPhoneNumber, egadMySchoolName, egadAddedByType, egadAddedByLoginId, egadDate, egadStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfGeneralAwarnessDetails.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfGeneralAwarnessDetails[] Search(TMSEvolutionOfGeneralAwarnessDetails searchObject)
	{
		return Search ( searchObject.EGADAwarnessId, searchObject.EGADSchoolId, searchObject.EGADSchoolSubId, searchObject.EGADStudentLoginId, searchObject.EGADMySurrounding, searchObject.EGADMyMotherName, searchObject.EGADMyFatherName, searchObject.EGADMyHomeAddress, searchObject.EGADMyPhoneNumber, searchObject.EGADMySchoolName, searchObject.EGADAddedByType, searchObject.EGADAddedByLoginId, searchObject.EGADDate, searchObject.EGADStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfGeneralAwarnessDetails objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfGeneralAwarnessDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfGeneralAwarnessDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

