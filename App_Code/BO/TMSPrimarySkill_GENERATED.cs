/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/6/2012 3:10:00 PM                                    */
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
public partial class TMSPrimarySkill
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_PrimarySkill]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _psSkillId;
	private System.Int64? _psSchoolId;
	private System.Int64? _psSchoolSubId;
	private System.Int64? _psSubjectId;
	private System.Int64? _psFacultyId;
	private System.String _psSkillName;
	private System.String _psSkillDescription;
	private System.String _psExtra;
	private System.DateTime? _psDate;
	private System.Int32? _psStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PSSkillId
	{
		get
		{
			return _psSkillId;
		}
		set
		{
			_psSkillId = value;
		}
	}
	
	public System.Int64? PSSchoolId
	{
		get
		{
			return _psSchoolId;
		}
		set
		{
			_psSchoolId = value;
		}
	}
	
	public System.Int64? PSSchoolSubId
	{
		get
		{
			return _psSchoolSubId;
		}
		set
		{
			_psSchoolSubId = value;
		}
	}
	
	public System.Int64? PSSubjectId
	{
		get
		{
			return _psSubjectId;
		}
		set
		{
			_psSubjectId = value;
		}
	}
	
	public System.Int64? PSFacultyId
	{
		get
		{
			return _psFacultyId;
		}
		set
		{
			_psFacultyId = value;
		}
	}
	
	public System.String PSSkillName
	{
		get
		{
			return _psSkillName;
		}
		set
		{
			_psSkillName = value;
		}
	}
	
	public System.String PSSkillDescription
	{
		get
		{
			return _psSkillDescription;
		}
		set
		{
			_psSkillDescription = value;
		}
	}
	
	public System.String PSExtra
	{
		get
		{
			return _psExtra;
		}
		set
		{
			_psExtra = value;
		}
	}
	
	public System.DateTime? PSDate
	{
		get
		{
			return _psDate;
		}
		set
		{
			_psDate = value;
		}
	}
	
	public System.Int32? PSStatus
	{
		get
		{
			return _psStatus;
		}
		set
		{
			_psStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PS_SkillId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_SkillName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_SkillDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PS_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PSSkillId == null)
		dr["PS_SkillId"] = DBNull.Value;
		else
		dr["PS_SkillId"] = PSSkillId;
		
		if (PSSchoolId == null)
		dr["PS_SchoolId"] = DBNull.Value;
		else
		dr["PS_SchoolId"] = PSSchoolId;
		
		if (PSSchoolSubId == null)
		dr["PS_SchoolSubId"] = DBNull.Value;
		else
		dr["PS_SchoolSubId"] = PSSchoolSubId;
		
		if (PSSubjectId == null)
		dr["PS_SubjectId"] = DBNull.Value;
		else
		dr["PS_SubjectId"] = PSSubjectId;
		
		if (PSFacultyId == null)
		dr["PS_FacultyId"] = DBNull.Value;
		else
		dr["PS_FacultyId"] = PSFacultyId;
		
		if (PSSkillName == null)
		dr["PS_SkillName"] = DBNull.Value;
		else
		dr["PS_SkillName"] = PSSkillName;
		
		if (PSSkillDescription == null)
		dr["PS_SkillDescription"] = DBNull.Value;
		else
		dr["PS_SkillDescription"] = PSSkillDescription;
		
		if (PSExtra == null)
		dr["PS_Extra"] = DBNull.Value;
		else
		dr["PS_Extra"] = PSExtra;
		
		if (PSDate == null)
		dr["PS_Date"] = DBNull.Value;
		else
		dr["PS_Date"] = PSDate;
		
		if (PSStatus == null)
		dr["PS_Status"] = DBNull.Value;
		else
		dr["PS_Status"] = PSStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PSSkillId = dr["PS_SkillId"] != DBNull.Value ? Convert.ToInt64(dr["PS_SkillId"]) : PSSkillId = null;
		PSSchoolId = dr["PS_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["PS_SchoolId"]) : PSSchoolId = null;
		PSSchoolSubId = dr["PS_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["PS_SchoolSubId"]) : PSSchoolSubId = null;
		PSSubjectId = dr["PS_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["PS_SubjectId"]) : PSSubjectId = null;
		PSFacultyId = dr["PS_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["PS_FacultyId"]) : PSFacultyId = null;
		PSSkillName = dr["PS_SkillName"] != DBNull.Value ? Convert.ToString(dr["PS_SkillName"]) : PSSkillName = null;
		PSSkillDescription = dr["PS_SkillDescription"] != DBNull.Value ? Convert.ToString(dr["PS_SkillDescription"]) : PSSkillDescription = null;
		PSExtra = dr["PS_Extra"] != DBNull.Value ? Convert.ToString(dr["PS_Extra"]) : PSExtra = null;
		PSDate = dr["PS_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PS_Date"]) : PSDate = null;
		PSStatus = dr["PS_Status"] != DBNull.Value ? Convert.ToInt32(dr["PS_Status"]) : PSStatus = null;
	}
	
	public static TMSPrimarySkill[] MapFrom(DataSet ds)
	{
		List<TMSPrimarySkill> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPrimarySkill>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_PrimarySkill] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_PrimarySkill] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPrimarySkill instance = new TMSPrimarySkill();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrimarySkill Get(System.Int64 psSkillId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPrimarySkill instance;
		
		
		instance = new TMSPrimarySkill();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psSkillId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0)// throw new ApplicationException("Could not get TMSPrimarySkill ID:" + psSkillId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psSchoolId, psSchoolSubId, psSubjectId, psFacultyId, psSkillName, psSkillDescription, psExtra, psDate, psStatus);
		
		if (transaction == null)
		this.PSSkillId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PSSkillId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus)
	{
		Insert(psSchoolId, psSchoolSubId, psSubjectId, psFacultyId, psSkillName, psSkillDescription, psExtra, psDate, psStatus, null);
	}
	/// <summary>
	/// Insert current TMSPrimarySkill to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PSSchoolId, PSSchoolSubId, PSSubjectId, PSFacultyId, PSSkillName, PSSkillDescription, PSExtra, PSDate, PSStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPrimarySkill to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? psSkillId, System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@psSkillId"].Value = psSkillId;
		dbCommand.Parameters["@psSchoolId"].Value = psSchoolId;
		dbCommand.Parameters["@psSchoolSubId"].Value = psSchoolSubId;
		dbCommand.Parameters["@psSubjectId"].Value = psSubjectId;
		dbCommand.Parameters["@psFacultyId"].Value = psFacultyId;
		dbCommand.Parameters["@psSkillName"].Value = psSkillName;
		dbCommand.Parameters["@psSkillDescription"].Value = psSkillDescription;
		dbCommand.Parameters["@psExtra"].Value = psExtra;
		dbCommand.Parameters["@psDate"].Value = psDate;
		dbCommand.Parameters["@psStatus"].Value = psStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? psSkillId, System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus)
	{
		Update(psSkillId, psSchoolId, psSchoolSubId, psSubjectId, psFacultyId, psSkillName, psSkillDescription, psExtra, psDate, psStatus, null);
	}
	
	public static void Update(TMSPrimarySkill tMSPrimarySkill)
	{
		tMSPrimarySkill.Update();
	}
	
	public static void Update(TMSPrimarySkill tMSPrimarySkill, DbTransaction transaction)
	{
		tMSPrimarySkill.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPrimarySkill_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@psSkillId"].SourceColumn = "PS_SkillId";
		dbCommand.Parameters["@psSchoolId"].SourceColumn = "PS_SchoolId";
		dbCommand.Parameters["@psSchoolSubId"].SourceColumn = "PS_SchoolSubId";
		dbCommand.Parameters["@psSubjectId"].SourceColumn = "PS_SubjectId";
		dbCommand.Parameters["@psFacultyId"].SourceColumn = "PS_FacultyId";
		dbCommand.Parameters["@psSkillName"].SourceColumn = "PS_SkillName";
		dbCommand.Parameters["@psSkillDescription"].SourceColumn = "PS_SkillDescription";
		dbCommand.Parameters["@psExtra"].SourceColumn = "PS_Extra";
		dbCommand.Parameters["@psDate"].SourceColumn = "PS_Date";
		dbCommand.Parameters["@psStatus"].SourceColumn = "PS_Status";
		
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
	public static void Delete(System.Int64? psSkillId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psSkillId);
		
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
	public static void Delete(System.Int64? psSkillId)
	{
		Delete(
		psSkillId);
	}
	
	/// <summary>
	/// Delete current TMSPrimarySkill from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PSSkillId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PSSkillId = null;
	}
	
	/// <summary>
	/// Delete current TMSPrimarySkill from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPrimarySkill[] Search(System.Int64? psSkillId, System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPrimarySkill_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, psSkillId, psSchoolId, psSchoolSubId, psSubjectId, psFacultyId, psSkillName, psSkillDescription, psExtra, psDate, psStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPrimarySkill.MapFrom(ds);
	}
	
	
	public static TMSPrimarySkill[] Search(TMSPrimarySkill searchObject)
	{
		return Search ( searchObject.PSSkillId, searchObject.PSSchoolId, searchObject.PSSchoolSubId, searchObject.PSSubjectId, searchObject.PSFacultyId, searchObject.PSSkillName, searchObject.PSSkillDescription, searchObject.PSExtra, searchObject.PSDate, searchObject.PSStatus);
	}
	
	/// <summary>
	/// Returns all TMSPrimarySkill objects.
	/// </summary>
	/// <returns>List of all TMSPrimarySkill objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPrimarySkill[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

