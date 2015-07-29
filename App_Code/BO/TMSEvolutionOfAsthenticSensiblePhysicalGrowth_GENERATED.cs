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
public partial class TMSEvolutionOfAsthenticSensiblePhysicalGrowth
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EvolutionOfAsthenticSensiblePhysicalGrowth]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _egdGrowthId;
	private System.Int64? _egdSchoolId;
	private System.Int64? _egdSchoolSubId;
	private System.Int64? _egdStudentLoginId;
	private System.String _egdMudAndSandPlay;
	private System.String _egdSplashPool;
	private System.String _egdLikeColourPainting;
	private System.String _egdPatternWriting;
	private System.String _egdPaperTearingPastingCraftWork;
	private System.String _egdInterestArtActivites;
	private System.String _egdInterestMusicDramaActivites;
	private System.String _egdInterestPhysicalActivites;
	private System.String _egdAddedByType;
	private System.Int64? _egdAddedByLoginId;
	private System.DateTime? _egdDate;
	private System.Int32? _egdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? EGDGrowthId
	{
		get
		{
			return _egdGrowthId;
		}
		set
		{
			_egdGrowthId = value;
		}
	}
	
	public System.Int64? EGDSchoolId
	{
		get
		{
			return _egdSchoolId;
		}
		set
		{
			_egdSchoolId = value;
		}
	}
	
	public System.Int64? EGDSchoolSubId
	{
		get
		{
			return _egdSchoolSubId;
		}
		set
		{
			_egdSchoolSubId = value;
		}
	}
	
	public System.Int64? EGDStudentLoginId
	{
		get
		{
			return _egdStudentLoginId;
		}
		set
		{
			_egdStudentLoginId = value;
		}
	}
	
	public System.String EGDMudAndSandPlay
	{
		get
		{
			return _egdMudAndSandPlay;
		}
		set
		{
			_egdMudAndSandPlay = value;
		}
	}
	
	public System.String EGDSplashPool
	{
		get
		{
			return _egdSplashPool;
		}
		set
		{
			_egdSplashPool = value;
		}
	}
	
	public System.String EGDLikeColourPainting
	{
		get
		{
			return _egdLikeColourPainting;
		}
		set
		{
			_egdLikeColourPainting = value;
		}
	}
	
	public System.String EGDPatternWriting
	{
		get
		{
			return _egdPatternWriting;
		}
		set
		{
			_egdPatternWriting = value;
		}
	}
	
	public System.String EGDPaperTearingPastingCraftWork
	{
		get
		{
			return _egdPaperTearingPastingCraftWork;
		}
		set
		{
			_egdPaperTearingPastingCraftWork = value;
		}
	}
	
	public System.String EGDInterestArtActivites
	{
		get
		{
			return _egdInterestArtActivites;
		}
		set
		{
			_egdInterestArtActivites = value;
		}
	}
	
	public System.String EGDInterestMusicDramaActivites
	{
		get
		{
			return _egdInterestMusicDramaActivites;
		}
		set
		{
			_egdInterestMusicDramaActivites = value;
		}
	}
	
	public System.String EGDInterestPhysicalActivites
	{
		get
		{
			return _egdInterestPhysicalActivites;
		}
		set
		{
			_egdInterestPhysicalActivites = value;
		}
	}
	
	public System.String EGDAddedByType
	{
		get
		{
			return _egdAddedByType;
		}
		set
		{
			_egdAddedByType = value;
		}
	}
	
	public System.Int64? EGDAddedByLoginId
	{
		get
		{
			return _egdAddedByLoginId;
		}
		set
		{
			_egdAddedByLoginId = value;
		}
	}
	
	public System.DateTime? EGDDate
	{
		get
		{
			return _egdDate;
		}
		set
		{
			_egdDate = value;
		}
	}
	
	public System.Int32? EGDStatus
	{
		get
		{
			return _egdStatus;
		}
		set
		{
			_egdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("EGD_GrowthId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_MudAndSandPlay", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_SplashPool", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_LikeColourPainting", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_PatternWriting", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_PaperTearingPastingCraftWork", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_InterestArtActivites", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_InterestMusicDramaActivites", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_InterestPhysicalActivites", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_AddedByLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("EGD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (EGDGrowthId == null)
		dr["EGD_GrowthId"] = DBNull.Value;
		else
		dr["EGD_GrowthId"] = EGDGrowthId;
		
		if (EGDSchoolId == null)
		dr["EGD_SchoolId"] = DBNull.Value;
		else
		dr["EGD_SchoolId"] = EGDSchoolId;
		
		if (EGDSchoolSubId == null)
		dr["EGD_SchoolSubId"] = DBNull.Value;
		else
		dr["EGD_SchoolSubId"] = EGDSchoolSubId;
		
		if (EGDStudentLoginId == null)
		dr["EGD_StudentLoginId"] = DBNull.Value;
		else
		dr["EGD_StudentLoginId"] = EGDStudentLoginId;
		
		if (EGDMudAndSandPlay == null)
		dr["EGD_MudAndSandPlay"] = DBNull.Value;
		else
		dr["EGD_MudAndSandPlay"] = EGDMudAndSandPlay;
		
		if (EGDSplashPool == null)
		dr["EGD_SplashPool"] = DBNull.Value;
		else
		dr["EGD_SplashPool"] = EGDSplashPool;
		
		if (EGDLikeColourPainting == null)
		dr["EGD_LikeColourPainting"] = DBNull.Value;
		else
		dr["EGD_LikeColourPainting"] = EGDLikeColourPainting;
		
		if (EGDPatternWriting == null)
		dr["EGD_PatternWriting"] = DBNull.Value;
		else
		dr["EGD_PatternWriting"] = EGDPatternWriting;
		
		if (EGDPaperTearingPastingCraftWork == null)
		dr["EGD_PaperTearingPastingCraftWork"] = DBNull.Value;
		else
		dr["EGD_PaperTearingPastingCraftWork"] = EGDPaperTearingPastingCraftWork;
		
		if (EGDInterestArtActivites == null)
		dr["EGD_InterestArtActivites"] = DBNull.Value;
		else
		dr["EGD_InterestArtActivites"] = EGDInterestArtActivites;
		
		if (EGDInterestMusicDramaActivites == null)
		dr["EGD_InterestMusicDramaActivites"] = DBNull.Value;
		else
		dr["EGD_InterestMusicDramaActivites"] = EGDInterestMusicDramaActivites;
		
		if (EGDInterestPhysicalActivites == null)
		dr["EGD_InterestPhysicalActivites"] = DBNull.Value;
		else
		dr["EGD_InterestPhysicalActivites"] = EGDInterestPhysicalActivites;
		
		if (EGDAddedByType == null)
		dr["EGD_AddedByType"] = DBNull.Value;
		else
		dr["EGD_AddedByType"] = EGDAddedByType;
		
		if (EGDAddedByLoginId == null)
		dr["EGD_AddedByLoginId"] = DBNull.Value;
		else
		dr["EGD_AddedByLoginId"] = EGDAddedByLoginId;
		
		if (EGDDate == null)
		dr["EGD_Date"] = DBNull.Value;
		else
		dr["EGD_Date"] = EGDDate;
		
		if (EGDStatus == null)
		dr["EGD_Status"] = DBNull.Value;
		else
		dr["EGD_Status"] = EGDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		EGDGrowthId = dr["EGD_GrowthId"] != DBNull.Value ? Convert.ToInt64(dr["EGD_GrowthId"]) : EGDGrowthId = null;
		EGDSchoolId = dr["EGD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["EGD_SchoolId"]) : EGDSchoolId = null;
		EGDSchoolSubId = dr["EGD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["EGD_SchoolSubId"]) : EGDSchoolSubId = null;
		EGDStudentLoginId = dr["EGD_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EGD_StudentLoginId"]) : EGDStudentLoginId = null;
		EGDMudAndSandPlay = dr["EGD_MudAndSandPlay"] != DBNull.Value ? Convert.ToString(dr["EGD_MudAndSandPlay"]) : EGDMudAndSandPlay = null;
		EGDSplashPool = dr["EGD_SplashPool"] != DBNull.Value ? Convert.ToString(dr["EGD_SplashPool"]) : EGDSplashPool = null;
		EGDLikeColourPainting = dr["EGD_LikeColourPainting"] != DBNull.Value ? Convert.ToString(dr["EGD_LikeColourPainting"]) : EGDLikeColourPainting = null;
		EGDPatternWriting = dr["EGD_PatternWriting"] != DBNull.Value ? Convert.ToString(dr["EGD_PatternWriting"]) : EGDPatternWriting = null;
		EGDPaperTearingPastingCraftWork = dr["EGD_PaperTearingPastingCraftWork"] != DBNull.Value ? Convert.ToString(dr["EGD_PaperTearingPastingCraftWork"]) : EGDPaperTearingPastingCraftWork = null;
		EGDInterestArtActivites = dr["EGD_InterestArtActivites"] != DBNull.Value ? Convert.ToString(dr["EGD_InterestArtActivites"]) : EGDInterestArtActivites = null;
		EGDInterestMusicDramaActivites = dr["EGD_InterestMusicDramaActivites"] != DBNull.Value ? Convert.ToString(dr["EGD_InterestMusicDramaActivites"]) : EGDInterestMusicDramaActivites = null;
		EGDInterestPhysicalActivites = dr["EGD_InterestPhysicalActivites"] != DBNull.Value ? Convert.ToString(dr["EGD_InterestPhysicalActivites"]) : EGDInterestPhysicalActivites = null;
		EGDAddedByType = dr["EGD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["EGD_AddedByType"]) : EGDAddedByType = null;
		EGDAddedByLoginId = dr["EGD_AddedByLoginId"] != DBNull.Value ? Convert.ToInt64(dr["EGD_AddedByLoginId"]) : EGDAddedByLoginId = null;
		EGDDate = dr["EGD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["EGD_Date"]) : EGDDate = null;
		EGDStatus = dr["EGD_Status"] != DBNull.Value ? Convert.ToInt32(dr["EGD_Status"]) : EGDStatus = null;
	}
	
	public static TMSEvolutionOfAsthenticSensiblePhysicalGrowth[] MapFrom(DataSet ds)
	{
		List<TMSEvolutionOfAsthenticSensiblePhysicalGrowth> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEvolutionOfAsthenticSensiblePhysicalGrowth>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EvolutionOfAsthenticSensiblePhysicalGrowth] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EvolutionOfAsthenticSensiblePhysicalGrowth] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEvolutionOfAsthenticSensiblePhysicalGrowth instance = new TMSEvolutionOfAsthenticSensiblePhysicalGrowth();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfAsthenticSensiblePhysicalGrowth Get(System.Int64 egdGrowthId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEvolutionOfAsthenticSensiblePhysicalGrowth instance;
		
		
		instance = new TMSEvolutionOfAsthenticSensiblePhysicalGrowth();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egdGrowthId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEvolutionOfAsthenticSensiblePhysicalGrowth ID:" + egdGrowthId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egdSchoolId, egdSchoolSubId, egdStudentLoginId, egdMudAndSandPlay, egdSplashPool, egdLikeColourPainting, egdPatternWriting, egdPaperTearingPastingCraftWork, egdInterestArtActivites, egdInterestMusicDramaActivites, egdInterestPhysicalActivites, egdAddedByType, egdAddedByLoginId, egdDate, egdStatus);
		
		if (transaction == null)
		this.EGDGrowthId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.EGDGrowthId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus)
	{
		Insert(egdSchoolId, egdSchoolSubId, egdStudentLoginId, egdMudAndSandPlay, egdSplashPool, egdLikeColourPainting, egdPatternWriting, egdPaperTearingPastingCraftWork, egdInterestArtActivites, egdInterestMusicDramaActivites, egdInterestPhysicalActivites, egdAddedByType, egdAddedByLoginId, egdDate, egdStatus, null);
	}
	/// <summary>
	/// Insert current TMSEvolutionOfAsthenticSensiblePhysicalGrowth to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(EGDSchoolId, EGDSchoolSubId, EGDStudentLoginId, EGDMudAndSandPlay, EGDSplashPool, EGDLikeColourPainting, EGDPatternWriting, EGDPaperTearingPastingCraftWork, EGDInterestArtActivites, EGDInterestMusicDramaActivites, EGDInterestPhysicalActivites, EGDAddedByType, EGDAddedByLoginId, EGDDate, EGDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEvolutionOfAsthenticSensiblePhysicalGrowth to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? egdGrowthId, System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@egdGrowthId"].Value = egdGrowthId;
		dbCommand.Parameters["@egdSchoolId"].Value = egdSchoolId;
		dbCommand.Parameters["@egdSchoolSubId"].Value = egdSchoolSubId;
		dbCommand.Parameters["@egdStudentLoginId"].Value = egdStudentLoginId;
		dbCommand.Parameters["@egdMudAndSandPlay"].Value = egdMudAndSandPlay;
		dbCommand.Parameters["@egdSplashPool"].Value = egdSplashPool;
		dbCommand.Parameters["@egdLikeColourPainting"].Value = egdLikeColourPainting;
		dbCommand.Parameters["@egdPatternWriting"].Value = egdPatternWriting;
		dbCommand.Parameters["@egdPaperTearingPastingCraftWork"].Value = egdPaperTearingPastingCraftWork;
		dbCommand.Parameters["@egdInterestArtActivites"].Value = egdInterestArtActivites;
		dbCommand.Parameters["@egdInterestMusicDramaActivites"].Value = egdInterestMusicDramaActivites;
		dbCommand.Parameters["@egdInterestPhysicalActivites"].Value = egdInterestPhysicalActivites;
		dbCommand.Parameters["@egdAddedByType"].Value = egdAddedByType;
		dbCommand.Parameters["@egdAddedByLoginId"].Value = egdAddedByLoginId;
		dbCommand.Parameters["@egdDate"].Value = egdDate;
		dbCommand.Parameters["@egdStatus"].Value = egdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? egdGrowthId, System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus)
	{
		Update(egdGrowthId, egdSchoolId, egdSchoolSubId, egdStudentLoginId, egdMudAndSandPlay, egdSplashPool, egdLikeColourPainting, egdPatternWriting, egdPaperTearingPastingCraftWork, egdInterestArtActivites, egdInterestMusicDramaActivites, egdInterestPhysicalActivites, egdAddedByType, egdAddedByLoginId, egdDate, egdStatus, null);
	}
	
	public static void Update(TMSEvolutionOfAsthenticSensiblePhysicalGrowth tMSEvolutionOfAsthenticSensiblePhysicalGrowth)
	{
		tMSEvolutionOfAsthenticSensiblePhysicalGrowth.Update();
	}
	
	public static void Update(TMSEvolutionOfAsthenticSensiblePhysicalGrowth tMSEvolutionOfAsthenticSensiblePhysicalGrowth, DbTransaction transaction)
	{
		tMSEvolutionOfAsthenticSensiblePhysicalGrowth.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@egdGrowthId"].SourceColumn = "EGD_GrowthId";
		dbCommand.Parameters["@egdSchoolId"].SourceColumn = "EGD_SchoolId";
		dbCommand.Parameters["@egdSchoolSubId"].SourceColumn = "EGD_SchoolSubId";
		dbCommand.Parameters["@egdStudentLoginId"].SourceColumn = "EGD_StudentLoginId";
		dbCommand.Parameters["@egdMudAndSandPlay"].SourceColumn = "EGD_MudAndSandPlay";
		dbCommand.Parameters["@egdSplashPool"].SourceColumn = "EGD_SplashPool";
		dbCommand.Parameters["@egdLikeColourPainting"].SourceColumn = "EGD_LikeColourPainting";
		dbCommand.Parameters["@egdPatternWriting"].SourceColumn = "EGD_PatternWriting";
		dbCommand.Parameters["@egdPaperTearingPastingCraftWork"].SourceColumn = "EGD_PaperTearingPastingCraftWork";
		dbCommand.Parameters["@egdInterestArtActivites"].SourceColumn = "EGD_InterestArtActivites";
		dbCommand.Parameters["@egdInterestMusicDramaActivites"].SourceColumn = "EGD_InterestMusicDramaActivites";
		dbCommand.Parameters["@egdInterestPhysicalActivites"].SourceColumn = "EGD_InterestPhysicalActivites";
		dbCommand.Parameters["@egdAddedByType"].SourceColumn = "EGD_AddedByType";
		dbCommand.Parameters["@egdAddedByLoginId"].SourceColumn = "EGD_AddedByLoginId";
		dbCommand.Parameters["@egdDate"].SourceColumn = "EGD_Date";
		dbCommand.Parameters["@egdStatus"].SourceColumn = "EGD_Status";
		
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
	public static void Delete(System.Int64? egdGrowthId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egdGrowthId);
		
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
	public static void Delete(System.Int64? egdGrowthId)
	{
		Delete(
		egdGrowthId);
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfAsthenticSensiblePhysicalGrowth from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, EGDGrowthId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.EGDGrowthId = null;
	}
	
	/// <summary>
	/// Delete current TMSEvolutionOfAsthenticSensiblePhysicalGrowth from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEvolutionOfAsthenticSensiblePhysicalGrowth[] Search(System.Int64? egdGrowthId, System.Int64? egdSchoolId, System.Int64? egdSchoolSubId, System.Int64? egdStudentLoginId, System.String egdMudAndSandPlay, System.String egdSplashPool, System.String egdLikeColourPainting, System.String egdPatternWriting, System.String egdPaperTearingPastingCraftWork, System.String egdInterestArtActivites, System.String egdInterestMusicDramaActivites, System.String egdInterestPhysicalActivites, System.String egdAddedByType, System.Int64? egdAddedByLoginId, System.DateTime? egdDate, System.Int32? egdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEvolutionOfAsthenticSensiblePhysicalGrowth_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, egdGrowthId, egdSchoolId, egdSchoolSubId, egdStudentLoginId, egdMudAndSandPlay, egdSplashPool, egdLikeColourPainting, egdPatternWriting, egdPaperTearingPastingCraftWork, egdInterestArtActivites, egdInterestMusicDramaActivites, egdInterestPhysicalActivites, egdAddedByType, egdAddedByLoginId, egdDate, egdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEvolutionOfAsthenticSensiblePhysicalGrowth.MapFrom(ds);
	}
	
	
	public static TMSEvolutionOfAsthenticSensiblePhysicalGrowth[] Search(TMSEvolutionOfAsthenticSensiblePhysicalGrowth searchObject)
	{
		return Search ( searchObject.EGDGrowthId, searchObject.EGDSchoolId, searchObject.EGDSchoolSubId, searchObject.EGDStudentLoginId, searchObject.EGDMudAndSandPlay, searchObject.EGDSplashPool, searchObject.EGDLikeColourPainting, searchObject.EGDPatternWriting, searchObject.EGDPaperTearingPastingCraftWork, searchObject.EGDInterestArtActivites, searchObject.EGDInterestMusicDramaActivites, searchObject.EGDInterestPhysicalActivites, searchObject.EGDAddedByType, searchObject.EGDAddedByLoginId, searchObject.EGDDate, searchObject.EGDStatus);
	}
	
	/// <summary>
	/// Returns all TMSEvolutionOfAsthenticSensiblePhysicalGrowth objects.
	/// </summary>
	/// <returns>List of all TMSEvolutionOfAsthenticSensiblePhysicalGrowth objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEvolutionOfAsthenticSensiblePhysicalGrowth[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

