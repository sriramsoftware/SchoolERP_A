using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSPrimarySkill
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? psSkillId, System.Int64? psSchoolId, System.Int64? psSchoolSubId, System.Int64? psSubjectId, System.Int64? psFacultyId, System.String psSkillName, System.String psSkillDescription, System.String psExtra, System.DateTime? psDate, System.Int32? psStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPrimarySkill_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, psSkillId, psSchoolId, psSchoolSubId, psSubjectId, psFacultyId, psSkillName, psSkillDescription, psExtra, psDate, psStatus);

        return db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSPrimarySkill searchObject)
    {
        return GetSearch(searchObject.PSSkillId, searchObject.PSSchoolId, searchObject.PSSchoolSubId, searchObject.PSSubjectId, searchObject.PSFacultyId, searchObject.PSSkillName, searchObject.PSSkillDescription, searchObject.PSExtra, searchObject.PSDate, searchObject.PSStatus);
    }

    /// <summary>
    /// Returns all TMSPrimarySkill objects.
    /// </summary>
    /// <returns>List of all TMSPrimarySkill objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetSearch_SkillsIsExsist(System.Int64? skillId, System.String skillName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMS_SkillsIsexist_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, skillId, skillName);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
        
    }
}

