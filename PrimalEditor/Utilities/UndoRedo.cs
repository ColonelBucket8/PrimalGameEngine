using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace PrimalEditor.Utilities
{
    public interface IUndoRedo
    {
        string Name { get; }
        void Undo();
        void Redo();
    }

    public class UndeRedoAction : IUndoRedo
    {
        private Action _undoAction;
        private Action _redoAction;

        public string Name { get; }

        public UndeRedoAction(string name)
        {
            Name = name;
        }
        public UndeRedoAction(Action undo, Action redo, string name) : this(name)
        {
            Debug.Assert(undo != null && redo != null);
            _undoAction = undo;
            _redoAction = redo;
        }

        public void Redo() => _redoAction();


        public void Undo() => _undoAction();
    }

    public class UndoRedo
    {
        private readonly ObservableCollection<IUndoRedo> _redoList = new();
        private readonly ObservableCollection<IUndoRedo> _undoList = new();
        public ReadOnlyObservableCollection<IUndoRedo> RedoList { get; }
        public ReadOnlyObservableCollection<IUndoRedo> UndoList { get; }


        public UndoRedo()
        {
            RedoList = new ReadOnlyObservableCollection<IUndoRedo>(_redoList);
            UndoList = new ReadOnlyObservableCollection<IUndoRedo>(_undoList);
        }

        public void Reset()
        {
            _redoList.Clear();
            _undoList.Clear();
        }

        public void Undo()
        {
            if (_undoList.Any())
            {
                IUndoRedo cmd = _undoList.Last();
                _undoList.RemoveAt(_undoList.Count - 1);
                cmd.Undo();
                _redoList.Insert(0, cmd);
            }
        }

        public void Redo()
        {
            if (_redoList.Any())
            {
                IUndoRedo cmd = _redoList.First();
                _redoList.RemoveAt(0);
                cmd.Redo();
                _undoList.Add(cmd);
            }
        }

        public void Add(IUndoRedo cmd)
        {
            _undoList.Add(cmd);
            _redoList.Clear();
        }

    }
}
