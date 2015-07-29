/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/26/2012 10:08:37 AM                                    */
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
public partial class TMSBookDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BookDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bdDetailsId;
	private System.String _bdBookId;
	private System.Int64? _bdLibraryManagerId;
	private System.String _bdBookType;
	private System.Int64? _bdSubjectId;
	private System.Int64? _bdSchoolId;
	private System.String _bdBookName;
	private System.String _bdPublication;
	private System.String _bdAuthor;
	private System.String _bdTotalCopies;
	private System.String _bdAvailableCopies;
	private System.String _bdPerCopyCost;
	private System.String _bdTotalCost;
	private System.String _bdFor;
	private System.String _bdDescription;
	private System.DateTime? _bdDate;
	private System.Int32? _bdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BDDetailsId
	{
		get
		{
			return _bdDetailsId;
		}
		set
		{
			_bdDetailsId = value;
		}
	}
	
	public System.String BDBookId
	{
		get
		{
			return _bdBookId;
		}
		set
		{
			_bdBookId = value;
		}
	}
	
	public System.Int64? BDLibraryManagerId
	{
		get
		{
			return _bdLibraryManagerId;
		}
		set
		{
			_bdLibraryManagerId = value;
		}
	}
	
	public System.String BDBookType
	{
		get
		{
			return _bdBookType;
		}
		set
		{
			_bdBookType = value;
		}
	}
	
	public System.Int64? BDSubjectId
	{
		get
		{
			return _bdSubjectId;
		}
		set
		{
			_bdSubjectId = value;
		}
	}
	
	public System.Int64? BDSchoolId
	{
		get
		{
			return _bdSchoolId;
		}
		set
		{
			_bdSchoolId = value;
		}
	}
	
	public System.String BDBookName
	{
		get
		{
			return _bdBookName;
		}
		set
		{
			_bdBookName = value;
		}
	}
	
	public System.String BDPublication
	{
		get
		{
			return _bdPublication;
		}
		set
		{
			_bdPublication = value;
		}
	}
	
	public System.String BDAuthor
	{
		get
		{
			return _bdAuthor;
		}
		set
		{
			_bdAuthor = value;
		}
	}
	
	public System.String BDTotalCopies
	{
		get
		{
			return _bdTotalCopies;
		}
		set
		{
			_bdTotalCopies = value;
		}
	}
	
	public System.String BDAvailableCopies
	{
		get
		{
			return _bdAvailableCopies;
		}
		set
		{
			_bdAvailableCopies = value;
		}
	}
	
	public System.String BDPerCopyCost
	{
		get
		{
			return _bdPerCopyCost;
		}
		set
		{
			_bdPerCopyCost = value;
		}
	}
	
	public System.String BDTotalCost
	{
		get
		{
			return _bdTotalCost;
		}
		set
		{
			_bdTotalCost = value;
		}
	}
	
	public System.String BDFor
	{
		get
		{
			return _bdFor;
		}
		set
		{
			_bdFor = value;
		}
	}
	
	public System.String BDDescription
	{
		get
		{
			return _bdDescription;
		}
		set
		{
			_bdDescription = value;
		}
	}
	
	public System.DateTime? BDDate
	{
		get
		{
			return _bdDate;
		}
		set
		{
			_bdDate = value;
		}
	}
	
	public System.Int32? BDStatus
	{
		get
		{
			return _bdStatus;
		}
		set
		{
			_bdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BD_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BookId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_LibraryManagerId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BookType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_BookName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Publication", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Author", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_TotalCopies", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_AvailableCopies", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_PerCopyCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_TotalCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_For", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BDDetailsId == null)
		dr["BD_DetailsId"] = DBNull.Value;
		else
		dr["BD_DetailsId"] = BDDetailsId;
		
		if (BDBookId == null)
		dr["BD_BookId"] = DBNull.Value;
		else
		dr["BD_BookId"] = BDBookId;
		
		if (BDLibraryManagerId == null)
		dr["BD_LibraryManagerId"] = DBNull.Value;
		else
		dr["BD_LibraryManagerId"] = BDLibraryManagerId;
		
		if (BDBookType == null)
		dr["BD_BookType"] = DBNull.Value;
		else
		dr["BD_BookType"] = BDBookType;
		
		if (BDSubjectId == null)
		dr["BD_SubjectId"] = DBNull.Value;
		else
		dr["BD_SubjectId"] = BDSubjectId;
		
		if (BDSchoolId == null)
		dr["BD_SchoolId"] = DBNull.Value;
		else
		dr["BD_SchoolId"] = BDSchoolId;
		
		if (BDBookName == null)
		dr["BD_BookName"] = DBNull.Value;
		else
		dr["BD_BookName"] = BDBookName;
		
		if (BDPublication == null)
		dr["BD_Publication"] = DBNull.Value;
		else
		dr["BD_Publication"] = BDPublication;
		
		if (BDAuthor == null)
		dr["BD_Author"] = DBNull.Value;
		else
		dr["BD_Author"] = BDAuthor;
		
		if (BDTotalCopies == null)
		dr["BD_TotalCopies"] = DBNull.Value;
		else
		dr["BD_TotalCopies"] = BDTotalCopies;
		
		if (BDAvailableCopies == null)
		dr["BD_AvailableCopies"] = DBNull.Value;
		else
		dr["BD_AvailableCopies"] = BDAvailableCopies;
		
		if (BDPerCopyCost == null)
		dr["BD_PerCopyCost"] = DBNull.Value;
		else
		dr["BD_PerCopyCost"] = BDPerCopyCost;
		
		if (BDTotalCost == null)
		dr["BD_TotalCost"] = DBNull.Value;
		else
		dr["BD_TotalCost"] = BDTotalCost;
		
		if (BDFor == null)
		dr["BD_For"] = DBNull.Value;
		else
		dr["BD_For"] = BDFor;
		
		if (BDDescription == null)
		dr["BD_Description"] = DBNull.Value;
		else
		dr["BD_Description"] = BDDescription;
		
		if (BDDate == null)
		dr["BD_Date"] = DBNull.Value;
		else
		dr["BD_Date"] = BDDate;
		
		if (BDStatus == null)
		dr["BD_Status"] = DBNull.Value;
		else
		dr["BD_Status"] = BDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BDDetailsId = dr["BD_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["BD_DetailsId"]) : BDDetailsId = null;
		BDBookId = dr["BD_BookId"] != DBNull.Value ? Convert.ToString(dr["BD_BookId"]) : BDBookId = null;
		BDLibraryManagerId = dr["BD_LibraryManagerId"] != DBNull.Value ? Convert.ToInt64(dr["BD_LibraryManagerId"]) : BDLibraryManagerId = null;
		BDBookType = dr["BD_BookType"] != DBNull.Value ? Convert.ToString(dr["BD_BookType"]) : BDBookType = null;
		BDSubjectId = dr["BD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["BD_SubjectId"]) : BDSubjectId = null;
		BDSchoolId = dr["BD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["BD_SchoolId"]) : BDSchoolId = null;
		BDBookName = dr["BD_BookName"] != DBNull.Value ? Convert.ToString(dr["BD_BookName"]) : BDBookName = null;
		BDPublication = dr["BD_Publication"] != DBNull.Value ? Convert.ToString(dr["BD_Publication"]) : BDPublication = null;
		BDAuthor = dr["BD_Author"] != DBNull.Value ? Convert.ToString(dr["BD_Author"]) : BDAuthor = null;
		BDTotalCopies = dr["BD_TotalCopies"] != DBNull.Value ? Convert.ToString(dr["BD_TotalCopies"]) : BDTotalCopies = null;
		BDAvailableCopies = dr["BD_AvailableCopies"] != DBNull.Value ? Convert.ToString(dr["BD_AvailableCopies"]) : BDAvailableCopies = null;
		BDPerCopyCost = dr["BD_PerCopyCost"] != DBNull.Value ? Convert.ToString(dr["BD_PerCopyCost"]) : BDPerCopyCost = null;
		BDTotalCost = dr["BD_TotalCost"] != DBNull.Value ? Convert.ToString(dr["BD_TotalCost"]) : BDTotalCost = null;
		BDFor = dr["BD_For"] != DBNull.Value ? Convert.ToString(dr["BD_For"]) : BDFor = null;
		BDDescription = dr["BD_Description"] != DBNull.Value ? Convert.ToString(dr["BD_Description"]) : BDDescription = null;
		BDDate = dr["BD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BD_Date"]) : BDDate = null;
		BDStatus = dr["BD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BD_Status"]) : BDStatus = null;
	}
	
	public static TMSBookDetails[] MapFrom(DataSet ds)
	{
		List<TMSBookDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBookDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BookDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BookDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBookDetails instance = new TMSBookDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookDetails Get(System.Int64 bdDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBookDetails instance;
		
		
		instance = new TMSBookDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBookDetails ID:" + bdDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate, System.Int32? bdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdLibraryManagerId, bdBookType, bdSubjectId, bdSchoolId, bdBookName, bdPublication, bdAuthor, bdTotalCopies, bdAvailableCopies, bdPerCopyCost, bdTotalCost, bdFor, bdDescription, bdDate, bdStatus);
		
		if (transaction == null)
		this.BDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		Insert(bdLibraryManagerId, bdBookType, bdSubjectId, bdSchoolId, bdBookName, bdPublication, bdAuthor, bdTotalCopies, bdAvailableCopies, bdPerCopyCost, bdTotalCost, bdFor, bdDescription, bdDate, bdStatus, null);
	}
	/// <summary>
	/// Insert current TMSBookDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BDLibraryManagerId, BDBookType, BDSubjectId, BDSchoolId, BDBookName, BDPublication, BDAuthor, BDTotalCopies, BDAvailableCopies, BDPerCopyCost, BDTotalCost, BDFor, BDDescription, BDDate, BDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBookDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bdDetailsId, System.String bdBookId, System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdDetailsId"].Value = bdDetailsId;
		dbCommand.Parameters["@bdLibraryManagerId"].Value = bdBookId;
		dbCommand.Parameters["@bdBookType"].Value = bdLibraryManagerId;
		dbCommand.Parameters["@bdSubjectId"].Value = bdBookType;
		dbCommand.Parameters["@bdSchoolId"].Value = bdSubjectId;
		dbCommand.Parameters["@bdBookName"].Value = bdSchoolId;
		dbCommand.Parameters["@bdPublication"].Value = bdBookName;
		dbCommand.Parameters["@bdAuthor"].Value = bdPublication;
		dbCommand.Parameters["@bdTotalCopies"].Value = bdAuthor;
		dbCommand.Parameters["@bdAvailableCopies"].Value = bdTotalCopies;
		dbCommand.Parameters["@bdPerCopyCost"].Value = bdAvailableCopies;
		dbCommand.Parameters["@bdTotalCost"].Value = bdPerCopyCost;
		dbCommand.Parameters["@bdFor"].Value = bdTotalCost;
		dbCommand.Parameters["@bdDescription"].Value = bdFor;
		dbCommand.Parameters["@bdDate"].Value = bdDescription;
		dbCommand.Parameters["@bdStatus"].Value = bdDate;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bdDetailsId, System.String bdBookId, System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate)
	{
		Update(bdDetailsId, bdBookId, bdLibraryManagerId, bdBookType, bdSubjectId, bdSchoolId, bdBookName, bdPublication, bdAuthor, bdTotalCopies, bdAvailableCopies, bdPerCopyCost, bdTotalCost, bdFor, bdDescription, bdDate, null);
	}
	
	public static void Update(TMSBookDetails tMSBookDetails)
	{
		tMSBookDetails.Update();
	}
	
	public static void Update(TMSBookDetails tMSBookDetails, DbTransaction transaction)
	{
		tMSBookDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBookDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdDetailsId"].SourceColumn = "BD_DetailsId";
		dbCommand.Parameters["@bdLibraryManagerId"].SourceColumn = "BD_LibraryManagerId";
		dbCommand.Parameters["@bdBookType"].SourceColumn = "BD_BookType";
		dbCommand.Parameters["@bdSubjectId"].SourceColumn = "BD_SubjectId";
		dbCommand.Parameters["@bdSchoolId"].SourceColumn = "BD_SchoolId";
		dbCommand.Parameters["@bdBookName"].SourceColumn = "BD_BookName";
		dbCommand.Parameters["@bdPublication"].SourceColumn = "BD_Publication";
		dbCommand.Parameters["@bdAuthor"].SourceColumn = "BD_Author";
		dbCommand.Parameters["@bdTotalCopies"].SourceColumn = "BD_TotalCopies";
		dbCommand.Parameters["@bdAvailableCopies"].SourceColumn = "BD_AvailableCopies";
		dbCommand.Parameters["@bdPerCopyCost"].SourceColumn = "BD_PerCopyCost";
		dbCommand.Parameters["@bdTotalCost"].SourceColumn = "BD_TotalCost";
		dbCommand.Parameters["@bdFor"].SourceColumn = "BD_For";
		dbCommand.Parameters["@bdDescription"].SourceColumn = "BD_Description";
		dbCommand.Parameters["@bdDate"].SourceColumn = "BD_Date";
		dbCommand.Parameters["@bdStatus"].SourceColumn = "BD_Status";
		
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
	public static void Delete(System.Int64? bdDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdDetailsId);
		
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
	public static void Delete(System.Int64? bdDetailsId)
	{
		Delete(
		bdDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSBookDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BDDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BDDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSBookDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookDetails[] Search(System.Int64? bdDetailsId, System.String bdBookId, System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdDetailsId, bdBookId, bdLibraryManagerId, bdBookType, bdSubjectId, bdSchoolId, bdBookName, bdPublication, bdAuthor, bdTotalCopies, bdAvailableCopies, bdPerCopyCost, bdTotalCost, bdFor, bdDescription, bdDate, bdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBookDetails.MapFrom(ds);
	}
	
	
	public static TMSBookDetails[] Search(TMSBookDetails searchObject)
	{
		return Search ( searchObject.BDDetailsId, searchObject.BDBookId, searchObject.BDLibraryManagerId, searchObject.BDBookType, searchObject.BDSubjectId, searchObject.BDSchoolId, searchObject.BDBookName, searchObject.BDPublication, searchObject.BDAuthor, searchObject.BDTotalCopies, searchObject.BDAvailableCopies, searchObject.BDPerCopyCost, searchObject.BDTotalCost, searchObject.BDFor, searchObject.BDDescription, searchObject.BDDate, searchObject.BDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBookDetails objects.
	/// </summary>
	/// <returns>List of all TMSBookDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBookDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

