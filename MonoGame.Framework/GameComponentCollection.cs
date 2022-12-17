// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.Collections.ObjectModel;
using MonoGame.Framework.Utilities;

namespace Microsoft.Xna.Framework;

/// <summary>
/// A collection of <see cref="IGameComponent"/> instances.
/// </summary>
public sealed class GameComponentCollection : Collection<IGameComponent>
{
    /// <summary>
    /// Event that is triggered when a <see cref="GameComponent"/> is added
    /// to this <see cref="GameComponentCollection"/>.
    /// </summary>
    public event EventHandler<GameComponentCollectionEventArgs> ComponentAdded;

    /// <summary>
    /// Event that is triggered when a <see cref="GameComponent"/> is removed
    /// from this <see cref="GameComponentCollection"/>.
    /// </summary>
    public event EventHandler<GameComponentCollectionEventArgs> ComponentRemoved;

    /// <summary>
    /// Removes every <see cref="GameComponent"/> from this <see cref="GameComponentCollection"/>.
    /// Triggers <see cref="OnComponentRemoved"/> once for each <see cref="GameComponent"/> removed.
    /// </summary>
    protected override void ClearItems()
    {
        for (int i = 0; i < Count; i++)
        {
            OnComponentRemoved(new GameComponentCollectionEventArgs(base[i]));
        }

        base.ClearItems();
    }

    protected override void InsertItem(int index, IGameComponent item)
    {
        if (IndexOf(item) != -1)
        {
            Throw.ArgumentException("Cannot Add Same Component Multiple Times");
        }

        base.InsertItem(index, item);
        if (item != null)
        {
            OnComponentAdded(new GameComponentCollectionEventArgs(item));
        }
    }

    private void OnComponentAdded(GameComponentCollectionEventArgs eventArgs)
    {
        EventHelpers.Raise(this, ComponentAdded, eventArgs);
    }

    private void OnComponentRemoved(GameComponentCollectionEventArgs eventArgs)
    {
        EventHelpers.Raise(this, ComponentRemoved, eventArgs);
    }

    protected override void RemoveItem(int index)
    {
        IGameComponent gameComponent = base[index];
        base.RemoveItem(index);
        if (gameComponent != null)
        {
            OnComponentRemoved(new GameComponentCollectionEventArgs(gameComponent));
        }
    }

    protected override void SetItem(int index, IGameComponent item) => Throw.NotSupportedException();
}
