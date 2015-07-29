/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/1/2012 3:36:54 PM                                    */
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
public partial class TMSScholasticMarksDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ScholasticMarksDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _mdMarksDetailsId;
	private System.Int64? _mdExamTestId;
	private System.Int64? _mdSchoolId;
	private System.Int64? _mdSchoolSubId;
	private System.Int64? _mdStudentLoginId;
	private System.Int64? _mdSubjectId;
	private System.String _mdObtainMarks;
	private System.String _mdGraceMarks;
	private System.String _mdTotalMarks;
	private System.DateTime? _mdDate;
	private System.Int64? _mdAddedById;
	private System.String _mdAddedType;
	private System.Int32? _mdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? MDMarksDetailsId
	{
		get
		{
			return _mdMarksDetailsId;
		}
		set
		{
			_mdMarksDetailsId = value;
		}
	}
	
	public System.Int64? MDExamTestId
	{
		get
		{
			return _mdExamTestId;
		}
		set
		{
			_mdExamTestId = value;
		}
	}
	
	public System.Int64? MDSchoolId
	{
		get
		{
			return _mdSchoolId;
		}
		set
		{
			_mdSchoolId = value;
		}
	}
	
	public System.Int64? MDSchoolSubId
	{
		get
		{
			return _mdSchoolSubId;
		}
		set
		{
			_mdSchoolSubId = value;
		}
	}
	
	public System.Int64? MDStudentLoginId
	{
		get
		{
			return _mdStudentLoginId;
		}
		set
		{
			_mdStudentLoginId = value;
		}
	}
	
	public System.Int64? MDSubjectId
	{
		get
		{
			return _mdSubjectId;
		}
		set
		{
			_mdSubjectId = value;
		}
	}
	
	public System.String MDObtainMarks
	{
		get
		{
			return _mdObtainMarks;
		}
		set
		{
			_mdObtainMarks = value;
		}
	}
	
	public System.String MDGraceMarks
	{
		get
		{
			return _mdGraceMarks;
		}
		set
		{
			_mdGraceMarks = value;
		}
	}
	
	public System.String MDTotalMarks
	{
		get
		{
			return _mdTotalMarks;
		}
		set
		{
			_mdTotalMarks = value;
		}
	}
	
	public System.DateTime? MDDate
	{
		get
		{
			return _mdDate;
		}
		set
		{
			_mdDate = value;
		}
	}
	
	public System.Int64? MDAddedById
	{
		get
		{
			return _mdAddedById;
		}
		set
		{
			_mdAddedById = value;
		}
	}
	
	public System.String MDAddedType
	{
		get
		{
			return _mdAddedType;
		}
		set
		{
			_mdAddedType = value;
		}
	}
	
	public System.Int32? MDStatus
	{
		get
		{
			return _mdStatus;
		}
		set
		{
			_mdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("MD_MarksDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_ExamTestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_ObtainMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_GraceMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_TotalMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_AddedType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (MDMarksDetailsId == null)
		dr["MD_MarksDetailsId"] = DBNull.Value;
		else
		dr["MD_MarksDetailsId"] = MDMarksDetailsId;
		
		if (MDExamTestId == null)
		dr["MD_ExamTestId"] = DBNull.Value;
		else
		dr["MD_ExamTestId"] = MDExamTestId;
		
		if (MDSchoolId == null)
		dr["MD_SchoolId"] = DBNull.Value;
		else
		dr["MD_SchoolId"] = MDSchoolId;
		
		if (MDSchoolSubId == null)
		dr["MD_SchoolSubId"] = DBNull.Value;
		else
		dr["MD_SchoolSubId"] = MDSchoolSubId;
		
		if (MDStudentLoginId == null)
		dr["MD_StudentLoginId"] = DBNull.Value;
		else
		dr["MD_StudentLoginId"] = MDStudentLoginId;
		
		if (MDSubjectId == null)
		dr["MD_SubjectId"] = DBNull.Value;
		else
		dr["MD_SubjectId"] = MDSubjectId;
		
		if (MDObtainMarks == null)
		dr["MD_ObtainMarks"] = DBNull.Value;
		else
		dr["MD_ObtainMarks"] = MDObtainMarks;
		
		if (MDGraceMarks == null)
		dr["MD_GraceMarks"] = DBNull.Value;
		else
		dr["MD_GraceMarks"] = MDGraceMarks;
		
		if (MDTotalMarks == null)
		dr["MD_TotalMarks"] = DBNull.Value;
		else
		dr["MD_TotalMarks"] = MDTotalMarks;
		
		if (MDDate == null)
		dr["MD_Date"] = DBNull.Value;
		else
		dr["MD_Date"] = MDDate;
		
		if (MDAddedById == null)
		dr["MD_AddedById"] = DBNull.Value;
		else
		dr["MD_AddedById"] = MDAddedById;
		
		if (MDAddedType == null)
		dr["MD_AddedType"] = DBNull.Value;
		else
		dr["MD_AddedType"] = MDAddedType;
		
		if (MDStatus == null)
		dr["MD_Status"] = DBNull.Value;
		else
		dr["MD_Status"] = MDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		MDMarksDetailsId = dr["MD_MarksDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["MD_MarksDetailsId"]) : MDMarksDetailsId = null;
		MDExamTestId = dr["MD_ExamTestId"] != DBNull.Value ? Convert.ToInt64(dr["MD_ExamTestId"]) : MDExamTestId = null;
		MDSchoolId = dr["MD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SchoolId"]) : MDSchoolId = null;
		MDSchoolSubId = dr["MD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SchoolSubId"]) : MDSchoolSubId = null;
		MDStudentLoginId = dr["MD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["MD_StudentLoginId"]) : MDStudentLoginId = null;
		MDSubjectId = dr["MD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["MD_SubjectId"]) : MDSubjectId = null;
		MDObtainMarks = dr["MD_ObtainMarks"] != DBNull.Value ? Convert.ToString(dr["MD_ObtainMarks"]) : MDObtainMarks = null;
		MDGraceMarks = dr["MD_GraceMarks"] != DBNull.Value ? Convert.ToString(dr["MD_GraceMarks"]) : MDGraceMarks = null;
		MDTotalMarks = dr["MD_TotalMarks"] != DBNull.Value ? Convert.ToString(dr["MD_TotalMarks"]) : MDTotalMarks = null;
		MDDate = dr["MD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["MD_Date"]) : MDDate = null;
		MDAddedById = dr["MD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["MD_AddedById"]) : MDAddedById = null;
		MDAddedType = dr["MD_AddedType"] != DBNull.Value ? Convert.ToString(dr["MD_AddedType"]) : MDAddedType = null;
		MDStatus = dr["MD_Status"] != DBNull.Value ? Convert.ToInt32(dr["MD_Status"]) : MDStatus = null;
	}
	
	public static TMSScholasticMarksDetails[] MapFrom(DataSet ds)
	{
		List<TMSScholasticMarksDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSScholasticMarksDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ScholasticMarksDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ScholasticMarksDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSScholasticMarksDetails instance = new TMSScholasticMarksDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticMarksDetails Get(System.Int64 mdMarksDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSScholasticMarksDetails instance;
		
		
		instance = new TMSScholasticMarksDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSScholasticMarksDetails ID:" + mdMarksDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdExamTestId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus);
		
		if (transaction == null)
		this.MDMarksDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.MDMarksDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus)
	{
		Insert(mdExamTestId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus, null);
	}
	/// <summary>
	/// Insert current TMSScholasticMarksDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(MDExamTestId, MDSchoolId, MDSchoolSubId, MDStudentLoginId, MDSubjectId, MDObtainMarks, MDGraceMarks, MDTotalMarks, MDDate, MDAddedById, MDAddedType, MDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSScholasticMarksDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? mdMarksDetailsId, System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mdMarksDetailsId"].Value = mdMarksDetailsId;
		dbCommand.Parameters["@mdExamTestId"].Value = mdExamTestId;
		dbCommand.Parameters["@mdSchoolId"].Value = mdSchoolId;
		dbCommand.Parameters["@mdSchoolSubId"].Value = mdSchoolSubId;
		dbCommand.Parameters["@mdStudentLoginId"].Value = mdStudentLoginId;
		dbCommand.Parameters["@mdSubjectId"].Value = mdSubjectId;
		dbCommand.Parameters["@mdObtainMarks"].Value = mdObtainMarks;
		dbCommand.Parameters["@mdGraceMarks"].Value = mdGraceMarks;
		dbCommand.Parameters["@mdTotalMarks"].Value = mdTotalMarks;
		dbCommand.Parameters["@mdDate"].Value = mdDate;
		dbCommand.Parameters["@mdAddedById"].Value = mdAddedById;
		dbCommand.Parameters["@mdAddedType"].Value = mdAddedType;
		dbCommand.Parameters["@mdStatus"].Value = mdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? mdMarksDetailsId, System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus)
	{
		Update(mdMarksDetailsId, mdExamTestId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus, null);
	}
	
	public static void Update(TMSScholasticMarksDetails tMSScholasticMarksDetails)
	{
		tMSScholasticMarksDetails.Update();
	}
	
	public static void Update(TMSScholasticMarksDetails tMSScholasticMarksDetails, DbTransaction transaction)
	{
		tMSScholasticMarksDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mdMarksDetailsId"].SourceColumn = "MD_MarksDetailsId";
		dbCommand.Parameters["@mdExamTestId"].SourceColumn = "MD_ExamTestId";
		dbCommand.Parameters["@mdSchoolId"].SourceColumn = "MD_SchoolId";
		dbCommand.Parameters["@mdSchoolSubId"].SourceColumn = "MD_SchoolSubId";
		dbCommand.Parameters["@mdStudentLoginId"].SourceColumn = "MD_StudentLoginId";
		dbCommand.Parameters["@mdSubjectId"].SourceColumn = "MD_SubjectId";
		dbCommand.Parameters["@mdObtainMarks"].SourceColumn = "MD_ObtainMarks";
		dbCommand.Parameters["@mdGraceMarks"].SourceColumn = "MD_GraceMarks";
		dbCommand.Parameters["@mdTotalMarks"].SourceColumn = "MD_TotalMarks";
		dbCommand.Parameters["@mdDate"].SourceColumn = "MD_Date";
		dbCommand.Parameters["@mdAddedById"].SourceColumn = "MD_AddedById";
		dbCommand.Parameters["@mdAddedType"].SourceColumn = "MD_AddedType";
		dbCommand.Parameters["@mdStatus"].SourceColumn = "MD_Status";
		
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
	public static void Delete(System.Int64? mdMarksDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId);
		
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
	public static void Delete(System.Int64? mdMarksDetailsId)
	{
		Delete(
		mdMarksDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSScholasticMarksDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, MDMarksDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.MDMarksDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSScholasticMarksDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSScholasticMarksDetails[] Search(System.Int64? mdMarksDetailsId, System.Int64? mdExamTestId, System.Int64? mdSchoolId, System.Int64? mdSchoolSubId, System.Int64? mdStudentLoginId, System.Int64? mdSubjectId, System.String mdObtainMarks, System.String mdGraceMarks, System.String mdTotalMarks, System.DateTime? mdDate, System.Int64? mdAddedById, System.String mdAddedType, System.Int32? mdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSScholasticMarksDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mdMarksDetailsId, mdExamTestId, mdSchoolId, mdSchoolSubId, mdStudentLoginId, mdSubjectId, mdObtainMarks, mdGraceMarks, mdTotalMarks, mdDate, mdAddedById, mdAddedType, mdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSScholasticMarksDetails.MapFrom(ds);
	}
	
	
	public static TMSScholasticMarksDetails[] Search(TMSScholasticMarksDetails searchObject)
	{
		return Search ( searchObject.MDMarksDetailsId, searchObject.MDExamTestId, searchObject.MDSchoolId, searchObject.MDSchoolSubId, searchObject.MDStudentLoginId, searchObject.MDSubjectId, searchObject.MDObtainMarks, searchObject.MDGraceMarks, searchObject.MDTotalMarks, searchObject.MDDate, searchObject.MDAddedById, searchObject.MDAddedType, searchObject.MDStatus);
	}
	
	/// <summary>
	/// Returns all TMSScholasticMarksDetails objects.
	/// </summary>
	/// <returns>List of all TMSScholasticMarksDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSScholasticMarksDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

