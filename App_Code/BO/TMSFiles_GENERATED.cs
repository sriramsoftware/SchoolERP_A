/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/6/2012 12:08:32 PM                                    */
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
public partial class TMSFiles
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Files]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fileID;
	private System.String _fileName;
	private System.String _filePath;
	private System.String _fileDescription;
	private System.Int32? _fileStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FileID
	{
		get
		{
			return _fileID;
		}
		set
		{
			_fileID = value;
		}
	}
	
	public System.String FileName
	{
		get
		{
			return _fileName;
		}
		set
		{
			_fileName = value;
		}
	}
	
	public System.String FilePath
	{
		get
		{
			return _filePath;
		}
		set
		{
			_filePath = value;
		}
	}
	
	public System.String FileDescription
	{
		get
		{
			return _fileDescription;
		}
		set
		{
			_fileDescription = value;
		}
	}
	
	public System.Int32? FileStatus
	{
		get
		{
			return _fileStatus;
		}
		set
		{
			_fileStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("File_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("File_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("File_Path", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("File_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("File_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FileID == null)
		dr["File_ID"] = DBNull.Value;
		else
		dr["File_ID"] = FileID;
		
		if (FileName == null)
		dr["File_Name"] = DBNull.Value;
		else
		dr["File_Name"] = FileName;
		
		if (FilePath == null)
		dr["File_Path"] = DBNull.Value;
		else
		dr["File_Path"] = FilePath;
		
		if (FileDescription == null)
		dr["File_Description"] = DBNull.Value;
		else
		dr["File_Description"] = FileDescription;
		
		if (FileStatus == null)
		dr["File_Status"] = DBNull.Value;
		else
		dr["File_Status"] = FileStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FileID = dr["File_ID"] != DBNull.Value ? Convert.ToInt64(dr["File_ID"]) : FileID = null;
		FileName = dr["File_Name"] != DBNull.Value ? Convert.ToString(dr["File_Name"]) : FileName = null;
		FilePath = dr["File_Path"] != DBNull.Value ? Convert.ToString(dr["File_Path"]) : FilePath = null;
		FileDescription = dr["File_Description"] != DBNull.Value ? Convert.ToString(dr["File_Description"]) : FileDescription = null;
		FileStatus = dr["File_Status"] != DBNull.Value ? Convert.ToInt32(dr["File_Status"]) : FileStatus = null;
	}
	
	public static TMSFiles[] MapFrom(DataSet ds)
	{
		List<TMSFiles> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFiles>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Files] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Files] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFiles instance = new TMSFiles();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFiles Get(System.Int64 fileID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFiles instance;
		
		
		instance = new TMSFiles();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fileID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFiles ID:" + fileID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fileName, filePath, fileDescription, fileStatus);
		
		if (transaction == null)
		this.FileID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FileID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus)
	{
		Insert(fileName, filePath, fileDescription, fileStatus, null);
	}
	/// <summary>
	/// Insert current TMSFiles to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FileName, FilePath, FileDescription, FileStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFiles to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fileID, System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fileID"].Value = fileID;
		dbCommand.Parameters["@fileName"].Value = fileName;
		dbCommand.Parameters["@filePath"].Value = filePath;
		dbCommand.Parameters["@fileDescription"].Value = fileDescription;
		dbCommand.Parameters["@fileStatus"].Value = fileStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fileID, System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus)
	{
		Update(fileID, fileName, filePath, fileDescription, fileStatus, null);
	}
	
	public static void Update(TMSFiles tMSFiles)
	{
		tMSFiles.Update();
	}
	
	public static void Update(TMSFiles tMSFiles, DbTransaction transaction)
	{
		tMSFiles.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFiles_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fileID"].SourceColumn = "File_ID";
		dbCommand.Parameters["@fileName"].SourceColumn = "File_Name";
		dbCommand.Parameters["@filePath"].SourceColumn = "File_Path";
		dbCommand.Parameters["@fileDescription"].SourceColumn = "File_Description";
		dbCommand.Parameters["@fileStatus"].SourceColumn = "File_Status";
		
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
	public static void Delete(System.Int64? fileID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fileID);
		
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
	public static void Delete(System.Int64? fileID)
	{
		Delete(
		fileID);
	}
	
	/// <summary>
	/// Delete current TMSFiles from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FileID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FileID = null;
	}
	
	/// <summary>
	/// Delete current TMSFiles from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFiles[] Search(System.Int64? fileID, System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFiles_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fileID, fileName, filePath, fileDescription, fileStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFiles.MapFrom(ds);
	}
	
	
	public static TMSFiles[] Search(TMSFiles searchObject)
	{
		return Search ( searchObject.FileID, searchObject.FileName, searchObject.FilePath, searchObject.FileDescription, searchObject.FileStatus);
	}
	
	/// <summary>
	/// Returns all TMSFiles objects.
	/// </summary>
	/// <returns>List of all TMSFiles objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFiles[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

