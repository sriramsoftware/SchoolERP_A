/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/31/2012 5:43:26 PM                                    */
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
public partial class TMSScholasticExamTestDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ScholasticExamTestDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _etdExamDetailsId;
	private System.String _etdExamCode;
	private System.Int64? _etdSchoolId;
	private System.Int64? _etdSubjectId;
	private System.String _etdExamType;
	private System.String _etdTitle;
	private System.String _etdDescription;
	private System.String _etdExtra1;
	private System.String _etdTotalMarks;
	private System.String _etdPassingMarks;
	private System.DateTime? _etdDate;
	private System.Int64? _etdAddedById;
	private System.String _etdAddedByType;
	private System.Int32? _etdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ETDExamDetailsId
	{
		get
		{
			return _etdExamDetailsId;
		}
		set
		{
			_etdExamDetailsId = value;
		}
	}
	
	public System.String ETDExamCode
	{
		get
		{
			return _etdExamCode;
		}
		set
		{
			_etdExamCode = value;
		}
	}
	
	public System.Int64? ETDSchoolId
	{
		get
		{
			return _etdSchoolId;
		}
		set
		{
			_etdSchoolId = value;
		}
	}
	
	public System.Int64? ETDSubjectId
	{
		get
		{
			return _etdSubjectId;
		}
		set
		{
			_etdSubjectId = value;
		}
	}
	
	public System.String ETDExamType
	{
		get
		{
			return _etdExamType;
		}
		set
		{
			_etdExamType = value;
		}
	}
	
	public System.String ETDTitle
	{
		get
		{
			return _etdTitle;
		}
		set
		{
			_etdTitle = value;
		}
	}
	
	public System.String ETDDescription
	{
		get
		{
			return _etdDescription;
		}
		set
		{
			_etdDescription = value;
		}
	}
	
	public System.String ETDExtra1
	{
		get
		{
			return _etdExtra1;
		}
		set
		{
			_etdExtra1 = value;
		}
	}
	
	public System.String ETDTotalMarks
	{
		get
		{
			return _etdTotalMarks;
		}
		set
		{
			_etdTotalMarks = value;
		}
	}
	
	public System.String ETDPassingMarks
	{
		get
		{
			return _etdPassingMarks;
		}
		set
		{
			_etdPassingMarks = value;
		}
	}
	
	public System.DateTime? ETDDate
	{
		get
		{
			return _etdDate;
		}
		set
		{
			_etdDate = value;
		}
	}
	
	public System.Int64? ETDAddedById
	{
		get
		{
			return _etdAddedById;
		}
		set
		{
			_etdAddedById = value;
		}
	}
	
	public System.String ETDAddedByType
	{
		get
		{
			return _etdAddedByType;
		}
		set
		{
			_etdAddedByType = value;
		}
	}
	
	public System.Int32? ETDStatus
	{
		get
		{
			return _etdStatus;
		}
		set
		{
			_etdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ETD_ExamDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_ExamCode", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_ExamType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_TotalMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_PassingMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ETD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ETDExamDetailsId == null)
		dr["ETD_ExamDetailsId"] = DBNull.Value;
		else
		dr["ETD_ExamDetailsId"] = ETDExamDetailsId;
		
		if (ETDExamCode == null)
		dr["ETD_ExamCode"] = DBNull.Value;
		else
		dr["ETD_ExamCode"] = ETDExamCode;
		
		if (ETDSchoolId == null)
		dr["ETD_SchoolId"] = DBNull.Value;
		else
		dr["ETD_SchoolId"] = ETDSchoolId;
		
		if (ETDSubjectId == null)
		dr["ETD_SubjectId"] = DBNull.Value;
		else
		dr["ETD_SubjectId"] = ETDSubjectId;
		
		if (ETDExamType == null)
		dr["ETD_ExamType"] = DBNull.Value;
		else
		dr["ETD_ExamType"] = ETDExamType;
		
		if (ETDTitle == null)
		dr["ETD_Title"] = DBNull.Value;
		else
		dr["ETD_Title"] = ETDTitle;
		
		if (ETDDescription == null)
		dr["ETD_Description"] = DBNull.Value;
		else
		dr["ETD_Description"] = ETDDescription;
		
		if (ETDExtra1 == null)
		dr["ETD_Extra1"] = DBNull.Value;
		else
		dr["ETD_Extra1"] = ETDExtra1;
		
		if (ETDTotalMarks == null)
		dr["ETD_TotalMarks"] = DBNull.Value;
		else
		dr["ETD_TotalMarks"] = ETDTotalMarks;
		
		if (ETDPassingMarks == null)
		dr["ETD_PassingMarks"] = DBNull.Value;
		else
		dr["ETD_PassingMarks"] = ETDPassingMarks;
		
		if (ETDDate == null)
		dr["ETD_Date"] = DBNull.Value;
		else
		dr["ETD_Date"] = ETDDate;
		
		if (ETDAddedById == null)
		dr["ETD_AddedById"] = DBNull.Value;
		else
		dr["ETD_AddedById"] = ETDAddedById;
		
		if (ETDAddedByType == null)
		dr["ETD_AddedByType"] = DBNull.Value;
		else
		dr["ETD_AddedByType"] = ETDAddedByType;
		
		if (ETDStatus == null)
		dr["ETD_Status"] = DBNull.Value;
		else
		dr["ETD_Status"] = ETDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ETDExamDetailsId = dr["ETD_ExamDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["ETD_ExamDetailsId"]) : ETDExamDetailsId = null;
		ETDExamCode = dr["ETD_ExamCode"] != DBNull.Value ? Convert.ToString(dr["ETD_ExamCode"]) : ETDExamCode = null;
		ETDSchoolId = dr["ETD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ETD_SchoolId"]) : ETDSchoolId = null;
		ETDSubjectId = dr["ETD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["ETD_SubjectId"]) : ETDSubjectId = null;
		ETDExamType = dr["ETD_ExamType"] != DBNull.Value ? Convert.ToString(dr["ETD_ExamType"]) : ETDExamType = null;
		ETDTitle = dr["ETD_Title"] != DBNull.Value ? Convert.ToString(dr["ETD_Title"]) : ETDTitle = null;
		ETDDescription = dr["ETD_Description"] != DBNull.Value ? Convert.ToString(dr["ETD_Description"]) : ETDDescription = null;
		ETDExtra1 = dr["ETD_Extra1"] != DBNull.Value ? Convert.ToString(dr["ETD_Extra1"]) : ETDExtra1 = null;
		ETDTotalMarks = dr["ETD_TotalMarks"] != DBNull.Value ? Convert.ToString(dr["ETD_TotalMarks"]) : ETDTotalMarks = null;
		ETDPassingMarks = dr["ETD_PassingMarks"] != DBNull.Value ? Convert.ToString(dr["ETD_PassingMarks"]) : ETDPassingMarks = null;
		ETDDate = dr["ETD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ETD_Date"]) : ETDDate = null;
		ETDAddedById = dr["ETD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["ETD_AddedById"]) : ETDAddedById = null;
		ETDAddedByType = dr["ETD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["ETD_AddedByType"]) : ETDAddedByType = null;
		ETDStatus = dr["ETD_Status"] != DBNull.Value ? Convert.ToInt32(dr["ETD_Status"]) : ETDStatus = null;
	}
	
	public static TMSScholasticExamTestDetails[] MapFrom(DataSet ds)
	{
		List<TMSScholasticExamTestDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSScholasticExamTestDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ScholasticExamTestDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ScholasticExamTestDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSScholasticExamTestDetails instance = new TMSScholasticExamTestDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticExamTestDetails Get(System.Int64 etdExamDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSScholasticExamTestDetails instance;
		
		
		instance = new TMSScholasticExamTestDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSScholasticExamTestDetails ID:" + etdExamDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamCode, etdSchoolId, etdSubjectId, etdExamType, etdTitle, etdDescription, etdExtra1, etdTotalMarks, etdPassingMarks, etdDate, etdAddedById, etdAddedByType, etdStatus);
		
		if (transaction == null)
		this.ETDExamDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ETDExamDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus)
	{
		Insert(etdExamCode, etdSchoolId, etdSubjectId, etdExamType, etdTitle, etdDescription, etdExtra1, etdTotalMarks, etdPassingMarks, etdDate, etdAddedById, etdAddedByType, etdStatus, null);
	}
	/// <summary>
	/// Insert current TMSScholasticExamTestDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ETDExamCode, ETDSchoolId, ETDSubjectId, ETDExamType, ETDTitle, ETDDescription, ETDExtra1, ETDTotalMarks, ETDPassingMarks, ETDDate, ETDAddedById, ETDAddedByType, ETDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSScholasticExamTestDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? etdExamDetailsId, System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etdExamDetailsId"].Value = etdExamDetailsId;
		dbCommand.Parameters["@etdExamCode"].Value = etdExamCode;
		dbCommand.Parameters["@etdSchoolId"].Value = etdSchoolId;
		dbCommand.Parameters["@etdSubjectId"].Value = etdSubjectId;
		dbCommand.Parameters["@etdExamType"].Value = etdExamType;
		dbCommand.Parameters["@etdTitle"].Value = etdTitle;
		dbCommand.Parameters["@etdDescription"].Value = etdDescription;
		dbCommand.Parameters["@etdExtra1"].Value = etdExtra1;
		dbCommand.Parameters["@etdTotalMarks"].Value = etdTotalMarks;
		dbCommand.Parameters["@etdPassingMarks"].Value = etdPassingMarks;
		dbCommand.Parameters["@etdDate"].Value = etdDate;
		dbCommand.Parameters["@etdAddedById"].Value = etdAddedById;
		dbCommand.Parameters["@etdAddedByType"].Value = etdAddedByType;
		dbCommand.Parameters["@etdStatus"].Value = etdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? etdExamDetailsId, System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus)
	{
		Update(etdExamDetailsId, etdExamCode, etdSchoolId, etdSubjectId, etdExamType, etdTitle, etdDescription, etdExtra1, etdTotalMarks, etdPassingMarks, etdDate, etdAddedById, etdAddedByType, etdStatus, null);
	}
	
	public static void Update(TMSScholasticExamTestDetails tMSScholasticExamTestDetails)
	{
		tMSScholasticExamTestDetails.Update();
	}
	
	public static void Update(TMSScholasticExamTestDetails tMSScholasticExamTestDetails, DbTransaction transaction)
	{
		tMSScholasticExamTestDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etdExamDetailsId"].SourceColumn = "ETD_ExamDetailsId";
		dbCommand.Parameters["@etdExamCode"].SourceColumn = "ETD_ExamCode";
		dbCommand.Parameters["@etdSchoolId"].SourceColumn = "ETD_SchoolId";
		dbCommand.Parameters["@etdSubjectId"].SourceColumn = "ETD_SubjectId";
		dbCommand.Parameters["@etdExamType"].SourceColumn = "ETD_ExamType";
		dbCommand.Parameters["@etdTitle"].SourceColumn = "ETD_Title";
		dbCommand.Parameters["@etdDescription"].SourceColumn = "ETD_Description";
		dbCommand.Parameters["@etdExtra1"].SourceColumn = "ETD_Extra1";
		dbCommand.Parameters["@etdTotalMarks"].SourceColumn = "ETD_TotalMarks";
		dbCommand.Parameters["@etdPassingMarks"].SourceColumn = "ETD_PassingMarks";
		dbCommand.Parameters["@etdDate"].SourceColumn = "ETD_Date";
		dbCommand.Parameters["@etdAddedById"].SourceColumn = "ETD_AddedById";
		dbCommand.Parameters["@etdAddedByType"].SourceColumn = "ETD_AddedByType";
		dbCommand.Parameters["@etdStatus"].SourceColumn = "ETD_Status";
		
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
	public static void Delete(System.Int64? etdExamDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamDetailsId);
		
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
	public static void Delete(System.Int64? etdExamDetailsId)
	{
		Delete(
		etdExamDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSScholasticExamTestDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ETDExamDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ETDExamDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSScholasticExamTestDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticExamTestDetails[] Search(System.Int64? etdExamDetailsId, System.String etdExamCode, System.Int64? etdSchoolId, System.Int64? etdSubjectId, System.String etdExamType, System.String etdTitle, System.String etdDescription, System.String etdExtra1, System.String etdTotalMarks, System.String etdPassingMarks, System.DateTime? etdDate, System.Int64? etdAddedById, System.String etdAddedByType, System.Int32? etdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticExamTestDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etdExamDetailsId, etdExamCode, etdSchoolId, etdSubjectId, etdExamType, etdTitle, etdDescription, etdExtra1, etdTotalMarks, etdPassingMarks, etdDate, etdAddedById, etdAddedByType, etdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSScholasticExamTestDetails.MapFrom(ds);
	}
	
	
	public static TMSScholasticExamTestDetails[] Search(TMSScholasticExamTestDetails searchObject)
	{
		return Search ( searchObject.ETDExamDetailsId, searchObject.ETDExamCode, searchObject.ETDSchoolId, searchObject.ETDSubjectId, searchObject.ETDExamType, searchObject.ETDTitle, searchObject.ETDDescription, searchObject.ETDExtra1, searchObject.ETDTotalMarks, searchObject.ETDPassingMarks, searchObject.ETDDate, searchObject.ETDAddedById, searchObject.ETDAddedByType, searchObject.ETDStatus);
	}
	
	/// <summary>
	/// Returns all TMSScholasticExamTestDetails objects.
	/// </summary>
	/// <returns>List of all TMSScholasticExamTestDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSScholasticExamTestDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

