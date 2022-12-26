﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Microsoft.Xna.Framework.Graphics;

// Summary:
//     Represents bone data for a model. Reference page contains links to related
//     conceptual articles.
public sealed class ModelBone
{
    private List<ModelBone> children = new();

    private List<ModelMesh> meshes = new();

    public List<ModelMesh> Meshes
    {
        get { return meshes; }
        private set { meshes = value; }
    }

    // Summary:
    //     Gets a collection of bones that are children of this bone.
    public ModelBoneCollection Children { get; private set; }

    //
    // Summary:
    //     Gets the index of this bone in the Bones collection.
    public int Index { get; set; }

    //
    // Summary:
    //     Gets the name of this bone.
    public string Name { get; set; }

    //
    // Summary:
    //     Gets the parent of this bone.
    public ModelBone Parent { get; set; }

    //
    // Summary:
    //     Gets or sets the matrix used to transform this bone relative to its parent
    //     bone.
    internal Matrix4x4 transform;

    public Matrix4x4 Transform
    {
        get { return transform; }
        set { transform = value; }
    }

    /// <summary>
    /// Transform of this node from the root of the model not from the parent
    /// </summary>
    public Matrix4x4 ModelTransform { get; set; }

    public ModelBone()
    {
        Children = new ModelBoneCollection(new List<ModelBone>());
    }

    public void AddMesh(ModelMesh mesh)
    {
        meshes.Add(mesh);
    }

    public void AddChild(ModelBone modelBone)
    {
        children.Add(modelBone);
        Children = new ModelBoneCollection(children);
    }
}

//// Summary:
////     Represents bone data for a model. Reference page contains links to related
////     conceptual articles.
//public sealed class ModelBone
//{
//    // Summary:
//    //     Gets a collection of bones that are children of this bone.
//    public ModelBoneCollection Children { get { throw new NotImplementedException(); } }
//    //
//    // Summary:
//    //     Gets the index of this bone in the Bones collection.
//    public int Index { get { throw new NotImplementedException(); } }
//    //
//    // Summary:
//    //     Gets the name of this bone.
//    public string Name { get { throw new NotImplementedException(); } }
//    //
//    // Summary:
//    //     Gets the parent of this bone.
//    public ModelBone Parent { get { throw new NotImplementedException(); } }
//    //
//    // Summary:
//    //     Gets or sets the matrix used to transform this bone relative to its parent
//    //     bone.
//    public Matrix Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
//}
