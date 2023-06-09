﻿namespace AppSettingsMini.Interfaces
{
	public interface ISettingsSourceProvider
    {
        IReadableSettingsSource ReadableSettingsStore { get; }
        IWriteableSettingsSource WriteableSettingsStore { get; }
    }
}