﻿using Michalcik.Logger.Formatters;
using Michalcik.Logger.Formatters.Default;
using Michalcik.Logger.Units;
using Michalcik.Logger.Writers;
using Michalcik.Logger.Writers.Default;
using System;
using System.Collections.Generic;

namespace Michalcik.Logger
{
    public static class Log
    {
        public static BaseLogger Logger { get; set; }

        public static void Initialize(LogLevel minLevel)
        {
            Logger = new BaseLogger(minLevel);
        }

        public static void Initialize(LogLevel minLevel, ILogUnitFactory unitFactory)
        {
            Logger = new BaseLogger(minLevel, unitFactory);
        }

        public static void AddConfiguration(ILogFormatter formatter, IEnumerable<ILogWriter> writers)
        {
            Logger?.AddConfiguration(formatter, writers);
        }

        public static void UseDefaultConfiguration(string path)
        {
            AddConfiguration(new LogFormatter(), new ILogWriter[] { new ConsoleWriter(), new FileWriter(path) });
        }

        public static void Debug(string message, object source)
        {
            Logger?.Debug(message, source);
        }

        public static void Debug(Exception exception, object source)
        {
            Logger?.Debug(exception, source);
        }

        public static void Info(string message, object source)
        {
            Logger?.Info(message, source);
        }

        public static void Info(Exception exception, object source)
        {
            Logger?.Info(exception, source);
        }

        public static void Warning(string message, object source)
        {
            Logger?.Warning(message, source);
        }

        public static void Warning(Exception exception, object source)
        {
            Logger?.Warning(exception, source);
        }

        public static void Error(string message, object source)
        {
            Logger?.Error(message, source);
        }

        public static void Error(Exception exception, object source)
        {
            Logger?.Error(exception, source);
        }
    }
}