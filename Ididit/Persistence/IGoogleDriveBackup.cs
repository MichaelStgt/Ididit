﻿using Ididit.Data;
using System.Threading.Tasks;

namespace Ididit.Persistence;

public interface IGoogleDriveBackup
{
    Task<DataModel> ImportData();
    void ExportData(IDataModel data);
}