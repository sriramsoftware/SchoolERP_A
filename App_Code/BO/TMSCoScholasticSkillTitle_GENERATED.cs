/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/31/2012 4:51:33 PM                                    */
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
public partial class TMSCoScholasticSkillTitle
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CoScholasticSkillTitle]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _stSkillTitleId;
	private System.Int64? _stSkillId;
	private System.String _stTitleName;
	private System.String _stTitleDescription;
	private System.String _stExtra;
	private System.DateTime? _stDate;
	private System.Int32? _stStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? STSkillTitleId
	{
		get
		{
			return _stSkillTitleId;
		}
		set
		{
			_stSkillTitleId = value;
		}
	}
	
	public System.Int64? STSkillId
	{
		get
		{
			return _stSkillId;
		}
		set
		{
			_stSkillId = value;
		}
	}
	
	public System.String STTitleName
	{
		get
		{
			return _stTitleName;
		}
		set
		{
			_stTitleName = value;
		}
	}
	
	public System.String STTitleDescription
	{
		get
		{
			return _stTitleDescription;
		}
		set
		{
			_stTitleDescription = value;
		}
	}
	
	public System.String STExtra
	{
		get
		{
			return _stExtra;
		}
		set
		{
			_stExtra = value;
		}
	}
	
	public System.DateTime? STDate
	{
		get
		{
			return _stDate;
		}
		set
		{
			_stDate = value;
		}
	}
	
	public System.Int32? STStatus
	{
		get
		{
			return _stStatus;
		}
		set
		{
			_stStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ST_SkillTitleId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_SkillId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_TitleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_TitleDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (STSkillTitleId == null)
		dr["ST_SkillTitleId"] = DBNull.Value;
		else
		dr["ST_SkillTitleId"] = STSkillTitleId;
		
		if (STSkillId == null)
		dr["ST_SkillId"] = DBNull.Value;
		else
		dr["ST_SkillId"] = STSkillId;
		
		if (STTitleName == null)
		dr["ST_TitleName"] = DBNull.Value;
		else
		dr["ST_TitleName"] = STTitleName;
		
		if (STTitleDescription == null)
		dr["ST_TitleDescription"] = DBNull.Value;
		else
		dr["ST_TitleDescription"] = STTitleDescription;
		
		if (STExtra == null)
		dr["ST_Extra"] = DBNull.Value;
		else
		dr["ST_Extra"] = STExtra;
		
		if (STDate == null)
		dr["ST_Date"] = DBNull.Value;
		else
		dr["ST_Date"] = STDate;
		
		if (STStatus == null)
		dr["ST_Status"] = DBNull.Value;
		else
		dr["ST_Status"] = STStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		STSkillTitleId = dr["ST_SkillTitleId"] != DBNull.Value ? Convert.ToInt64(dr["ST_SkillTitleId"]) : STSkillTitleId = null;
		STSkillId = dr["ST_SkillId"] != DBNull.Value ? Convert.ToInt64(dr["ST_SkillId"]) : STSkillId = null;
		STTitleName = dr["ST_TitleName"] != DBNull.Value ? Convert.ToString(dr["ST_TitleName"]) : STTitleName = null;
		STTitleDescription = dr["ST_TitleDescription"] != DBNull.Value ? Convert.ToString(dr["ST_TitleDescription"]) : STTitleDescription = null;
		STExtra = dr["ST_Extra"] != DBNull.Value ? Convert.ToString(dr["ST_Extra"]) : STExtra = null;
		STDate = dr["ST_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ST_Date"]) : STDate = null;
		STStatus = dr["ST_Status"] != DBNull.Value ? Convert.ToInt32(dr["ST_Status"]) : STStatus = null;
	}
	
	public static TMSCoScholasticSkillTitle[] MapFrom(DataSet ds)
	{
		List<TMSCoScholasticSkillTitle> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCoScholasticSkillTitle>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CoScholasticSkillTitle] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CoScholasticSkillTitle] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCoScholasticSkillTitle instance = new TMSCoScholasticSkillTitle();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticSkillTitle Get(System.Int64 stSkillTitleId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCoScholasticSkillTitle instance;
		
		
		instance = new TMSCoScholasticSkillTitle();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillTitleId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCoScholasticSkillTitle ID:" + stSkillTitleId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId, stTitleName, stTitleDescription, stExtra, stDate, stStatus);
		
		if (transaction == null)
		this.STSkillTitleId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.STSkillTitleId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		Insert(stSkillId, stTitleName, stTitleDescription, stExtra, stDate, stStatus, null);
	}
	/// <summary>
	/// Insert current TMSCoScholasticSkillTitle to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(STSkillId, STTitleName, STTitleDescription, STExtra, STDate, STStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCoScholasticSkillTitle to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? stSkillTitleId, System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stSkillTitleId"].Value = stSkillTitleId;
		dbCommand.Parameters["@stSkillId"].Value = stSkillId;
		dbCommand.Parameters["@stTitleName"].Value = stTitleName;
		dbCommand.Parameters["@stTitleDescription"].Value = stTitleDescription;
		dbCommand.Parameters["@stExtra"].Value = stExtra;
		dbCommand.Parameters["@stDate"].Value = stDate;
		dbCommand.Parameters["@stStatus"].Value = stStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? stSkillTitleId, System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		Update(stSkillTitleId, stSkillId, stTitleName, stTitleDescription, stExtra, stDate, stStatus, null);
	}
	
	public static void Update(TMSCoScholasticSkillTitle tMSCoScholasticSkillTitle)
	{
		tMSCoScholasticSkillTitle.Update();
	}
	
	public static void Update(TMSCoScholasticSkillTitle tMSCoScholasticSkillTitle, DbTransaction transaction)
	{
		tMSCoScholasticSkillTitle.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stSkillTitleId"].SourceColumn = "ST_SkillTitleId";
		dbCommand.Parameters["@stSkillId"].SourceColumn = "ST_SkillId";
		dbCommand.Parameters["@stTitleName"].SourceColumn = "ST_TitleName";
		dbCommand.Parameters["@stTitleDescription"].SourceColumn = "ST_TitleDescription";
		dbCommand.Parameters["@stExtra"].SourceColumn = "ST_Extra";
		dbCommand.Parameters["@stDate"].SourceColumn = "ST_Date";
		dbCommand.Parameters["@stStatus"].SourceColumn = "ST_Status";
		
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
	public static void Delete(System.Int64? stSkillTitleId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillTitleId);
		
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
	public static void Delete(System.Int64? stSkillTitleId)
	{
		Delete(
		stSkillTitleId);
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticSkillTitle from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, STSkillTitleId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.STSkillTitleId = null;
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticSkillTitle from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticSkillTitle[] Search(System.Int64? stSkillTitleId, System.Int64? stSkillId, System.String stTitleName, System.String stTitleDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticSkillTitle_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillTitleId, stSkillId, stTitleName, stTitleDescription, stExtra, stDate, stStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCoScholasticSkillTitle.MapFrom(ds);
	}
	
	
	public static TMSCoScholasticSkillTitle[] Search(TMSCoScholasticSkillTitle searchObject)
	{
		return Search ( searchObject.STSkillTitleId, searchObject.STSkillId, searchObject.STTitleName, searchObject.STTitleDescription, searchObject.STExtra, searchObject.STDate, searchObject.STStatus);
	}
	
	/// <summary>
	/// Returns all TMSCoScholasticSkillTitle objects.
	/// </summary>
	/// <returns>List of all TMSCoScholasticSkillTitle objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCoScholasticSkillTitle[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

