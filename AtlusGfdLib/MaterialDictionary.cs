﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AtlusGfdLib
{
    public sealed class MaterialDictionary : Resource, IDictionary<string, Material>
    {
        private readonly Dictionary<string, Material> mDictionary;

        public MaterialDictionary( uint version )
            : base( ResourceType.MaterialDictionary, version )
        {
            mDictionary = new Dictionary<string, Material>();
        }

        public Material this[string name]
        {
            get => mDictionary[name];
            set => mDictionary[name] = value;
        }

        public IList<Material> Materials
            => mDictionary.Values.ToList();

        public void Add( Material material )
            => mDictionary[material.Name] = material;

        public int Count => mDictionary.Count;

        public ICollection<string> Keys
            => ( ( IDictionary<string, Material> )mDictionary ).Keys;

        public ICollection<Material> Values
            => ( ( IDictionary<string, Material> )mDictionary ).Values;

        public bool IsReadOnly
            => ( ( IDictionary<string, Material> )mDictionary ).IsReadOnly;

        public void Clear() => mDictionary.Clear();

        public bool ContainsMaterial( string name )
            => mDictionary.ContainsKey( name );

        public bool ContainsMaterial( Material material )
            => mDictionary.ContainsValue( material );

        public bool Remove( string name )
            => mDictionary.Remove( name );

        public bool Remove( Material material )
            => mDictionary.Remove( material.Name );

        public bool TryGetMaterial( string name, out Material material )
        {
            return mDictionary.TryGetValue( name, out material );
        }

        public bool ContainsKey( string key )
        {
            return mDictionary.ContainsKey( key );
        }

        public void Add( string key, Material value )
        {
            mDictionary.Add( key, value );
        }

        public bool TryGetValue( string key, out Material value )
        {
            return mDictionary.TryGetValue( key, out value );
        }

        public void Add( KeyValuePair<string, Material> item )
        {
            ( ( IDictionary<string, Material> )mDictionary ).Add( item );
        }

        public bool Contains( KeyValuePair<string, Material> item )
        {
            return ( ( IDictionary<string, Material> )mDictionary ).Contains( item );
        }

        public void CopyTo( KeyValuePair<string, Material>[] array, int arrayIndex )
        {
            ( ( IDictionary<string, Material> )mDictionary ).CopyTo( array, arrayIndex );
        }

        public bool Remove( KeyValuePair<string, Material> item )
        {
            return ( ( IDictionary<string, Material> )mDictionary ).Remove( item );
        }

        public IEnumerator<KeyValuePair<string, Material>> GetEnumerator()
        {
            return ( ( IDictionary<string, Material> )mDictionary ).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ( ( IDictionary<string, Material> )mDictionary ).GetEnumerator();
        }
    }
}