﻿using System.IO;

namespace OctoAwesome.Serialization
{
    public interface ISerializable
    {
        void Serialize(BinaryWriter writer, IDefinitionManager definitionManager);
        void Deserialize(BinaryReader reader, IDefinitionManager definitionManager);
    }
}