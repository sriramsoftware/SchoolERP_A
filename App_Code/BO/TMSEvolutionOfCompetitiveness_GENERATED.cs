/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/5/2012 1:27:43 PM                                    */
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
public partial class TMSEvolutionOfCompetitiveness
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfCompetitiveness]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ecdCompetitiveId;
	private System.Int64? _ecdSchoolId;
	private System.Int64? _ecdSchoolSubId;
	private System.Int64? _ecdStudentLoginId;
	private System.String _ecdSelfIntroduction;
	private System.String _ecdRhymesRecitation;
	private System.String _ecdFancyDress;
	private System.String _ecdSongAndDance;
	private System.String _ecdColouring;
	private System.String _ecdArtAndCraft;
	private System.String _ecdAnnualDay;
	private System.String _ecdSportsDay;
	private System.String _ecdOtherEvents;
	private System.String _ecdAddedByType;
	private System.Int64? _ecdAddedByLoginId;
	private System.DateTime? _ecdDate;
	private System.Int32? _ecdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ECDCompetitiveId
	{
		get
		{
			return _ecdCompetitiveId;
		}
		set
		{
			_ecdCompetitiveId = value;
		}
	}
	
	public System.Int64? ECDSchoolId
	{
		get
		{
			return _ecdSchoolId;
		}
		set
		{
			_ecdSchoolId = value;
		}
	}
	
	public System.Int64? ECDSchoolSubId
	{
		get
		{
			return _ecdSchoolSubId;
		}
		set
		{
			_ecdSchoolSubId = value;
		}
	}
	
	public System.Int64? ECDStudentLoginId
	{
		get
		{
			return _ecdStudentLoginId;
		}
		set
		{
			_ecdStudentLoginId = value;
		}
	}
	
	public System.String ECDSelfIntroduction
	{
		get
		{
			return _ecdSelfIntroduction;
		}
		set
		{
			_ecdSelfIntroduction = value;
		}
	}
	
	public System.String ECDRhymesRecitation
	{
		get
		{
			return _ecdRhymesRecitation;
		}
		set
		{
			_ecdRhymesRecitation = value;
		}
	}
	
	public System.String ECDFancyDress
	{
		get
		{
			return _ecdFancyDress;
		}
		set
		{
			_ecdFancyDress = value;
		}
	}
	
	public System.String ECDSongAndDance
	{
		get
		{
			return _ecdSongAndDance;
		}
		set
		{
			_ecdSongAndDance = value;
		}
	}
	
	public System.String ECDColouring
	{
		get
		{
			return _ecdColouring;
		}
		set
		{
			_ecdColouring = value;
		}
	}
	
	public System.String ECDArtAndCraft
	{
		get
		{
			return _ecdArtAndCraft;
		}
		set
		{
			_ecdArtAndCraft = value;
		}
	}
	
	public System.String ECDAnnualDay
	{
		get
		{
			return _ecdAnnualDay;
		}
		set
		{
			_ecdAnnualDay = value;
		}
	}
	
	public System.String ECDSportsDay
	{
		get
		{
			return _ecdSportsDay;
		}
		set
		{
			_ecdSportsDay = value;
		}
	}
	
	public System.String ECDOtherEvents
	{
		get
		{
			return _ecdOtherEvents;
		}
		set
		{
			_ecdOtherEvents = value;
		}
	}
	
	public System.String ECDAddedByType
	{
		get
		{
			return _ecdAddedByType;
		}
		set
		{
			_ecdAddedByType = value;
		}
	}
	
	public System.Int64? ECDAddedByLoginId
	{
		get
		{
			return _ecdAddedByLoginId;
		}
		set
		{
			_ecdAddedByLoginId = value;
		}
	}
	
	public System.DateTime? ECDDate
	{
		get
		{
			return _ecdDate;
		}
		set
		{
			_ecdDate = value;
		}
	}
	
	public System.Int32? ECDStatus
	{
		get
		{
			return _ecdStatus;
		}
		set
		{
			_ecdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ECD_CompetitiveId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_SelfIntroduction", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_RhymesRecitation", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_FancyDress", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_SongAndDance", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_Colouring", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_ArtAndCraft", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_AnnualDay", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_SportsDay", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_OtherEvents", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ECD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ECDCompetitiveId == null)
		dr["ECD_CompetitiveId"] = DBNull.Value;
		else
		dr["ECD_CompetitiveId"] = ECDCompetitiveId;
		
		if (ECDSchoolId == null)
		dr["ECD_SchoolId"] = DBNull.Value;
		else
		dr["ECD_SchoolId"] = ECDSchoolId;
		
		if (ECDSchoolSubId == null)
		dr["ECD_SchoolSubId"] = DBNull.Value;
		else
		dr["ECD_SchoolSubId"] = ECDSchoolSubId;
		
		if (ECDStudentLoginId == null)
		dr["ECD_StudentLoginId"] = DBNull.Value;
		else
		dr["ECD_StudentLoginId"] = ECDStudentLoginId;
		
		if (ECDSelfIntroduction == null)
		dr["ECD_SelfIntroduction"] = DBNull.Value;
		else
		dr["ECD_SelfIntroduction"] = ECDSelfIntroduction;
		
		if (ECDRhymesRecitation == null)
		dr["ECD_RhymesRecitation"] = DBNull.Value;
		else
		dr["ECD_RhymesRecitation"] = ECDRhymesRecitation;
		
		if (ECDFancyDress == null)
		dr["ECD_FancyDress"] = DBNull.Value;
		else
		dr["ECD_FancyDress"] = ECDFancyDress;
		
		if (ECDSongAndDance == null)
		dr["ECD_SongAndDance"] = DBNull.Value;
		else
		dr["ECD_SongAndDance"] = ECDSongAndDance;
		
		if (ECDColouring == null)
		dr["ECD_Colouring"] = DBNull.Value;
		else
		dr["ECD_Colouring"] = ECDColouring;
		
		if (ECDArtAndCraft == null)
		dr["ECD_ArtAndCraft"] = DBNull.Value;
		else
		dr["ECD_ArtAndCraft"] = ECDArtAndCraft;
		
		if (ECDAnnualDay == null)
		dr["ECD_AnnualDay"] = DBNull.Value;
		else
		dr["ECD_AnnualDay"] = ECDAnnualDay;
		
		if (ECDSportsDay == null)
		dr["ECD_SportsDay"] = DBNull.Value;
		else
		dr["ECD_SportsDay"] = ECDSportsDay;
		
		if (ECDOtherEvents == null)
		dr["ECD_OtherEvents"] = DBNull.Value;
		else
		dr["ECD_OtherEvents"] = ECDOtherEvents;
		
		if (ECDAddedByType == null)
		dr["ECD_AddedByType"] = DBNull.Value;
		else
		dr["ECD_AddedByType"] = ECDAddedByType;
		
		if (ECDAddedByLoginId == null)
		dr["ECD_AddedByLoginId"] = DBNull.Value;
		else
		dr["ECD_AddedByLoginId"] = ECDAddedByLoginId;
		
		if (ECDDate == null)
		dr["ECD_Date"] = DBNull.Value;
		else
		dr["ECD_Date"] = ECDDate;
		
		if (ECDStatus == null)
		dr["ECD_Status"] = DBNull.Value;
		else
		dr["ECD_Status"] = ECDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ECDCompetitiveId = dr["ECD_CompetitiveId"] != DBNull.Value ? Convert.ToInt64(dr["ECD_CompetitiveId"]) : ECDCompetitiveId = null;
		ECDSchoolId = dr["ECD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ECD_SchoolId"]) : ECDSchoolId = null;
		ECDSchoolSubId = dr["ECD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ECD_SchoolSubId"]) : ECDSchoolSubId = null;
		ECDStudentLoginId = dr["ECD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ECD_StudentLoginId"]) : ECDStudentLoginId = null;
		ECDSelfIntroduction = dr["ECD_SelfIntroduction"] != DBNull.Value ? Convert.ToString(dr["ECD_SelfIntroduction"]) : ECDSelfIntroduction = null;
		ECDRhymesRecitation = dr["ECD_RhymesRecitation"] != DBNull.Value ? Convert.ToString(dr["ECD_RhymesRecitation"]) : ECDRhymesRecitation = null;
		ECDFancyDress = dr["ECD_FancyDress"] != DBNull.Value ? Convert.ToString(dr["ECD_FancyDress"]) : ECDFancyDress = null;
		ECDSongAndDance = dr["ECD_SongAndDance"] != DBNull.Value ? Convert.ToString(dr["ECD_SongAndDance"]) : ECDSongAndDance = null;
		ECDColouring = dr["ECD_Colouring"] != DBNull.Value ? Convert.ToString(dr["ECD_Colouring"]) : ECDColouring = null;
		ECDArtAndCraft = dr["ECD_ArtAndCraft"] != DBNull.Value ? Convert.ToString(dr["ECD_ArtAndCraft"]) : ECDArtAndCraft = null;
		ECDAnnualDay = dr["ECD_AnnualDay"] != DBNull.Value ? Convert.ToString(dr["ECD_AnnualDay"]) : ECDAnnualDay = null;
		ECDSportsDay = dr["ECD_SportsDay"] != DBNull.Value ? Convert.ToString(dr["ECD_SportsDay"]) : ECDSportsDay = null;
		ECDOtherEvents = dr["ECD_OtherEvents"] != DBNull.Value ? Convert.ToString(dr["ECD_OtherEvents"]) : ECDOtherEvents = null;
		ECDAddedByType = dr["ECD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["ECD_AddedByType"]) : ECDAddedByType = null;
		ECDAddedByLoginId = dr["ECD_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ECD_AddedByLoginId"]) : ECDAddedByLoginId = null;
		ECDDate = dr["ECD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ECD_Date"]) : ECDDate = null;
		ECDStatus = dr["ECD_Status"] != DBNull.Value ? Convert.ToInt32(dr["ECD_Status"]) : ECDStatus = null;
	}
	
	public static TMSEvolutionOfCompetitiveness[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfCompetitiveness> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfCompetitiveness>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfCompetitiveness] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfCompetitiveness] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfCompetitiveness instance = new TMSEvolutionOfCompetitiveness();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfCompetitiveness Get(System.Int64 ecdCompetitiveId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfCompetitiveness instance;
		
		
		instance = new TMSEvolutionOfCompetitiveness();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecdCompetitiveId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfCompetitiveness ID:" + ecdCompetitiveId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecdSchoolId, ecdSchoolSubId, ecdStudentLoginId, ecdSelfIntroduction, ecdRhymesRecitation, ecdFancyDress, ecdSongAndDance, ecdColouring, ecdArtAndCraft, ecdAnnualDay, ecdSportsDay, ecdOtherEvents, ecdAddedByType, ecdAddedByLoginId, ecdDate, ecdStatus);
		
		if (transaction == null)
		this.ECDCompetitiveId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ECDCompetitiveId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus)
	{
		Insert(ecdSchoolId, ecdSchoolSubId, ecdStudentLoginId, ecdSelfIntroduction, ecdRhymesRecitation, ecdFancyDress, ecdSongAndDance, ecdColouring, ecdArtAndCraft, ecdAnnualDay, ecdSportsDay, ecdOtherEvents, ecdAddedByType, ecdAddedByLoginId, ecdDate, ecdStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfCompetitiveness to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ECDSchoolId, ECDSchoolSubId, ECDStudentLoginId, ECDSelfIntroduction, ECDRhymesRecitation, ECDFancyDress, ECDSongAndDance, ECDColouring, ECDArtAndCraft, ECDAnnualDay, ECDSportsDay, ECDOtherEvents, ECDAddedByType, ECDAddedByLoginId, ECDDate, ECDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfCompetitiveness to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ecdCompetitiveId, System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ecdCompetitiveId"].Value = ecdCompetitiveId;
		dbCommand.Parameters["@ecdSchoolId"].Value = ecdSchoolId;
		dbCommand.Parameters["@ecdSchoolSubId"].Value = ecdSchoolSubId;
		dbCommand.Parameters["@ecdStudentLoginId"].Value = ecdStudentLoginId;
		dbCommand.Parameters["@ecdSelfIntroduction"].Value = ecdSelfIntroduction;
		dbCommand.Parameters["@ecdRhymesRecitation"].Value = ecdRhymesRecitation;
		dbCommand.Parameters["@ecdFancyDress"].Value = ecdFancyDress;
		dbCommand.Parameters["@ecdSongAndDance"].Value = ecdSongAndDance;
		dbCommand.Parameters["@ecdColouring"].Value = ecdColouring;
		dbCommand.Parameters["@ecdArtAndCraft"].Value = ecdArtAndCraft;
		dbCommand.Parameters["@ecdAnnualDay"].Value = ecdAnnualDay;
		dbCommand.Parameters["@ecdSportsDay"].Value = ecdSportsDay;
		dbCommand.Parameters["@ecdOtherEvents"].Value = ecdOtherEvents;
		dbCommand.Parameters["@ecdAddedByType"].Value = ecdAddedByType;
		dbCommand.Parameters["@ecdAddedByLoginId"].Value = ecdAddedByLoginId;
		dbCommand.Parameters["@ecdDate"].Value = ecdDate;
		dbCommand.Parameters["@ecdStatus"].Value = ecdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ecdCompetitiveId, System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus)
	{
		Update(ecdCompetitiveId, ecdSchoolId, ecdSchoolSubId, ecdStudentLoginId, ecdSelfIntroduction, ecdRhymesRecitation, ecdFancyDress, ecdSongAndDance, ecdColouring, ecdArtAndCraft, ecdAnnualDay, ecdSportsDay, ecdOtherEvents, ecdAddedByType, ecdAddedByLoginId, ecdDate, ecdStatus, null);
	}
	
	public static void Update(TMSEvolutionOfCompetitiveness tMSEvolutionOfCompetitiveness)
	{
		tMSEvolutionOfCompetitiveness.Update();
	}
	
	public static void Update(TMSEvolutionOfCompetitiveness tMSEvolutionOfCompetitiveness, DbTransaction transaction)
	{
		tMSEvolutionOfCompetitiveness.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ecdCompetitiveId"].SourceColumn = "ECD_CompetitiveId";
		dbCommand.Parameters["@ecdSchoolId"].SourceColumn = "ECD_SchoolId";
		dbCommand.Parameters["@ecdSchoolSubId"].SourceColumn = "ECD_SchoolSubId";
		dbCommand.Parameters["@ecdStudentLoginId"].SourceColumn = "ECD_StudentLoginId";
		dbCommand.Parameters["@ecdSelfIntroduction"].SourceColumn = "ECD_SelfIntroduction";
		dbCommand.Parameters["@ecdRhymesRecitation"].SourceColumn = "ECD_RhymesRecitation";
		dbCommand.Parameters["@ecdFancyDress"].SourceColumn = "ECD_FancyDress";
		dbCommand.Parameters["@ecdSongAndDance"].SourceColumn = "ECD_SongAndDance";
		dbCommand.Parameters["@ecdColouring"].SourceColumn = "ECD_Colouring";
		dbCommand.Parameters["@ecdArtAndCraft"].SourceColumn = "ECD_ArtAndCraft";
		dbCommand.Parameters["@ecdAnnualDay"].SourceColumn = "ECD_AnnualDay";
		dbCommand.Parameters["@ecdSportsDay"].SourceColumn = "ECD_SportsDay";
		dbCommand.Parameters["@ecdOtherEvents"].SourceColumn = "ECD_OtherEvents";
		dbCommand.Parameters["@ecdAddedByType"].SourceColumn = "ECD_AddedByType";
		dbCommand.Parameters["@ecdAddedByLoginId"].SourceColumn = "ECD_AddedByLoginId";
		dbCommand.Parameters["@ecdDate"].SourceColumn = "ECD_Date";
		dbCommand.Parameters["@ecdStatus"].SourceColumn = "ECD_Status";
		
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
	public static void Delete(System.Int64? ecdCompetitiveId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecdCompetitiveId);
		
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
	public static void Delete(System.Int64? ecdCompetitiveId)
	{
		Delete(
		ecdCompetitiveId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfCompetitiveness from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ECDCompetitiveId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ECDCompetitiveId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfCompetitiveness from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfCompetitiveness[] Search(System.Int64? ecdCompetitiveId, System.Int64? ecdSchoolId, System.Int64? ecdSchoolSubId, System.Int64? ecdStudentLoginId, System.String ecdSelfIntroduction, System.String ecdRhymesRecitation, System.String ecdFancyDress, System.String ecdSongAndDance, System.String ecdColouring, System.String ecdArtAndCraft, System.String ecdAnnualDay, System.String ecdSportsDay, System.String ecdOtherEvents, System.String ecdAddedByType, System.Int64? ecdAddedByLoginId, System.DateTime? ecdDate, System.Int32? ecdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfCompetitiveness_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ecdCompetitiveId, ecdSchoolId, ecdSchoolSubId, ecdStudentLoginId, ecdSelfIntroduction, ecdRhymesRecitation, ecdFancyDress, ecdSongAndDance, ecdColouring, ecdArtAndCraft, ecdAnnualDay, ecdSportsDay, ecdOtherEvents, ecdAddedByType, ecdAddedByLoginId, ecdDate, ecdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfCompetitiveness.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfCompetitiveness[] Search(TMSEvolutionOfCompetitiveness searchObject)
	{
		return Search ( searchObject.ECDCompetitiveId, searchObject.ECDSchoolId, searchObject.ECDSchoolSubId, searchObject.ECDStudentLoginId, searchObject.ECDSelfIntroduction, searchObject.ECDRhymesRecitation, searchObject.ECDFancyDress, searchObject.ECDSongAndDance, searchObject.ECDColouring, searchObject.ECDArtAndCraft, searchObject.ECDAnnualDay, searchObject.ECDSportsDay, searchObject.ECDOtherEvents, searchObject.ECDAddedByType, searchObject.ECDAddedByLoginId, searchObject.ECDDate, searchObject.ECDStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfCompetitiveness objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfCompetitiveness objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfCompetitiveness[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

