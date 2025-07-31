﻿using System;
using System.Windows.Input;

namespace StatusUpdater.Helpers;
public class RelayCommand : ICommand
{
    private readonly Action<object?> _exec;
    private readonly Predicate<object?>? _can;
    public RelayCommand(Action<object?> exec, Predicate<object?>? can = null) { _exec = exec; _can = can; }
    public bool CanExecute(object? parameter) => _can?.Invoke(parameter) ?? true;
    public void Execute(object? parameter) => _exec(parameter);
    public event EventHandler? CanExecuteChanged { add { CommandManager.RequerySuggested += value; } remove { CommandManager.RequerySuggested -= value; } }
}
