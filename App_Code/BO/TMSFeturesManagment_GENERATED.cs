/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/9/2012 3:25:56 PM                                    */
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
public partial class TMSFeturesManagment
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeturesManagment]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fmFutureID;
	private System.Int64? _fmFuturedDetailsID;
	private System.String _fmTitle;
	private System.String _fmSubTitle;
	private System.String _fmDescription;
	private System.String _fmImage;
	private System.String _fmImage2;
	private System.String _fmDescrption2;
	private System.DateTime? _fmDate;
	private System.Int32? _fmStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FMFutureID
	{
		get
		{
			return _fmFutureID;
		}
		set
		{
			_fmFutureID = value;
		}
	}
	
	public System.Int64? FMFuturedDetailsID
	{
		get
		{
			return _fmFuturedDetailsID;
		}
		set
		{
			_fmFuturedDetailsID = value;
		}
	}
	
	public System.String FMTitle
	{
		get
		{
			return _fmTitle;
		}
		set
		{
			_fmTitle = value;
		}
	}
	
	public System.String FMSubTitle
	{
		get
		{
			return _fmSubTitle;
		}
		set
		{
			_fmSubTitle = value;
		}
	}
	
	public System.String FMDescription
	{
		get
		{
			return _fmDescription;
		}
		set
		{
			_fmDescription = value;
		}
	}
	
	public System.String FMImage
	{
		get
		{
			return _fmImage;
		}
		set
		{
			_fmImage = value;
		}
	}
	
	public System.String FMImage2
	{
		get
		{
			return _fmImage2;
		}
		set
		{
			_fmImage2 = value;
		}
	}
	
	public System.String FMDescrption2
	{
		get
		{
			return _fmDescrption2;
		}
		set
		{
			_fmDescrption2 = value;
		}
	}
	
	public System.DateTime? FMDate
	{
		get
		{
			return _fmDate;
		}
		set
		{
			_fmDate = value;
		}
	}
	
	public System.Int32? FMStatus
	{
		get
		{
			return _fmStatus;
		}
		set
		{
			_fmStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FM_FutureID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_FuturedDetailsID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_SubTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Image2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Descrption2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FM_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FMFutureID == null)
		dr["FM_FutureID"] = DBNull.Value;
		else
		dr["FM_FutureID"] = FMFutureID;
		
		if (FMFuturedDetailsID == null)
		dr["FM_FuturedDetailsID"] = DBNull.Value;
		else
		dr["FM_FuturedDetailsID"] = FMFuturedDetailsID;
		
		if (FMTitle == null)
		dr["FM_Title"] = DBNull.Value;
		else
		dr["FM_Title"] = FMTitle;
		
		if (FMSubTitle == null)
		dr["FM_SubTitle"] = DBNull.Value;
		else
		dr["FM_SubTitle"] = FMSubTitle;
		
		if (FMDescription == null)
		dr["FM_Description"] = DBNull.Value;
		else
		dr["FM_Description"] = FMDescription;
		
		if (FMImage == null)
		dr["FM_Image"] = DBNull.Value;
		else
		dr["FM_Image"] = FMImage;
		
		if (FMImage2 == null)
		dr["FM_Image2"] = DBNull.Value;
		else
		dr["FM_Image2"] = FMImage2;
		
		if (FMDescrption2 == null)
		dr["FM_Descrption2"] = DBNull.Value;
		else
		dr["FM_Descrption2"] = FMDescrption2;
		
		if (FMDate == null)
		dr["FM_Date"] = DBNull.Value;
		else
		dr["FM_Date"] = FMDate;
		
		if (FMStatus == null)
		dr["FM_Status"] = DBNull.Value;
		else
		dr["FM_Status"] = FMStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FMFutureID = dr["FM_FutureID"] != DBNull.Value ? Convert.ToInt64(dr["FM_FutureID"]) : FMFutureID = null;
		FMFuturedDetailsID = dr["FM_FuturedDetailsID"] != DBNull.Value ? Convert.ToInt64(dr["FM_FuturedDetailsID"]) : FMFuturedDetailsID = null;
		FMTitle = dr["FM_Title"] != DBNull.Value ? Convert.ToString(dr["FM_Title"]) : FMTitle = null;
		FMSubTitle = dr["FM_SubTitle"] != DBNull.Value ? Convert.ToString(dr["FM_SubTitle"]) : FMSubTitle = null;
		FMDescription = dr["FM_Description"] != DBNull.Value ? Convert.ToString(dr["FM_Description"]) : FMDescription = null;
		FMImage = dr["FM_Image"] != DBNull.Value ? Convert.ToString(dr["FM_Image"]) : FMImage = null;
		FMImage2 = dr["FM_Image2"] != DBNull.Value ? Convert.ToString(dr["FM_Image2"]) : FMImage2 = null;
		FMDescrption2 = dr["FM_Descrption2"] != DBNull.Value ? Convert.ToString(dr["FM_Descrption2"]) : FMDescrption2 = null;
		FMDate = dr["FM_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FM_Date"]) : FMDate = null;
		FMStatus = dr["FM_Status"] != DBNull.Value ? Convert.ToInt32(dr["FM_Status"]) : FMStatus = null;
	}
	
	public static TMSFeturesManagment[] MapFrom(DataSet ds)
	{
		List<TMSFeturesManagment> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeturesManagment>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeturesManagment] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeturesManagment] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeturesManagment instance = new TMSFeturesManagment();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeturesManagment Get(System.Int64 fmFutureID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeturesManagment instance;
		
		
		instance = new TMSFeturesManagment();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fmFutureID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeturesManagment ID:" + fmFutureID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fmFuturedDetailsID, fmTitle, fmSubTitle, fmDescription, fmImage, fmImage2, fmDescrption2, fmDate, fmStatus);
		
		if (transaction == null)
		this.FMFutureID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FMFutureID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus)
	{
		Insert(fmFuturedDetailsID, fmTitle, fmSubTitle, fmDescription, fmImage, fmImage2, fmDescrption2, fmDate, fmStatus, null);
	}
	/// <summary>
	/// Insert current TMSFeturesManagment to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FMFuturedDetailsID, FMTitle, FMSubTitle, FMDescription, FMImage, FMImage2, FMDescrption2, FMDate, FMStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeturesManagment to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fmFutureID, System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fmFutureID"].Value = fmFutureID;
		dbCommand.Parameters["@fmFuturedDetailsID"].Value = fmFuturedDetailsID;
		dbCommand.Parameters["@fmTitle"].Value = fmTitle;
		dbCommand.Parameters["@fmSubTitle"].Value = fmSubTitle;
		dbCommand.Parameters["@fmDescription"].Value = fmDescription;
		dbCommand.Parameters["@fmImage"].Value = fmImage;
		dbCommand.Parameters["@fmImage2"].Value = fmImage2;
		dbCommand.Parameters["@fmDescrption2"].Value = fmDescrption2;
		dbCommand.Parameters["@fmDate"].Value = fmDate;
		dbCommand.Parameters["@fmStatus"].Value = fmStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fmFutureID, System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus)
	{
		Update(fmFutureID, fmFuturedDetailsID, fmTitle, fmSubTitle, fmDescription, fmImage, fmImage2, fmDescrption2, fmDate, fmStatus, null);
	}
	
	public static void Update(TMSFeturesManagment tMSFeturesManagment)
	{
		tMSFeturesManagment.Update();
	}
	
	public static void Update(TMSFeturesManagment tMSFeturesManagment, DbTransaction transaction)
	{
		tMSFeturesManagment.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeturesManagment_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fmFutureID"].SourceColumn = "FM_FutureID";
		dbCommand.Parameters["@fmFuturedDetailsID"].SourceColumn = "FM_FuturedDetailsID";
		dbCommand.Parameters["@fmTitle"].SourceColumn = "FM_Title";
		dbCommand.Parameters["@fmSubTitle"].SourceColumn = "FM_SubTitle";
		dbCommand.Parameters["@fmDescription"].SourceColumn = "FM_Description";
		dbCommand.Parameters["@fmImage"].SourceColumn = "FM_Image";
		dbCommand.Parameters["@fmImage2"].SourceColumn = "FM_Image2";
		dbCommand.Parameters["@fmDescrption2"].SourceColumn = "FM_Descrption2";
		dbCommand.Parameters["@fmDate"].SourceColumn = "FM_Date";
		dbCommand.Parameters["@fmStatus"].SourceColumn = "FM_Status";
		
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
	public static void Delete(System.Int64? fmFutureID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fmFutureID);
		
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
	public static void Delete(System.Int64? fmFutureID)
	{
		Delete(
		fmFutureID);
	}
	
	/// <summary>
	/// Delete current TMSFeturesManagment from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FMFutureID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FMFutureID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeturesManagment from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeturesManagment[] Search(System.Int64? fmFutureID, System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeturesManagment_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fmFutureID, fmFuturedDetailsID, fmTitle, fmSubTitle, fmDescription, fmImage, fmImage2, fmDescrption2, fmDate, fmStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeturesManagment.MapFrom(ds);
	}
	
	
	public static TMSFeturesManagment[] Search(TMSFeturesManagment searchObject)
	{
		return Search ( searchObject.FMFutureID, searchObject.FMFuturedDetailsID, searchObject.FMTitle, searchObject.FMSubTitle, searchObject.FMDescription, searchObject.FMImage, searchObject.FMImage2, searchObject.FMDescrption2, searchObject.FMDate, searchObject.FMStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeturesManagment objects.
	/// </summary>
	/// <returns>List of all TMSFeturesManagment objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeturesManagment[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

