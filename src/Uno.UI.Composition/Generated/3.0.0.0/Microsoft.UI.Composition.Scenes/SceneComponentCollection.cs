#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition.Scenes
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SceneComponentCollection : global::Microsoft.UI.Composition.Scenes.SceneObject,global::System.Collections.Generic.IList<global::Microsoft.UI.Composition.Scenes.SceneComponent>,global::System.Collections.Generic.IEnumerable<global::Microsoft.UI.Composition.Scenes.SceneComponent>
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint SceneComponentCollection.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20SceneComponentCollection.Size");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.GetMany(uint, Microsoft.UI.Composition.Scenes.SceneComponent[])
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.First()
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.IndexOf(Microsoft.UI.Composition.Scenes.SceneComponent, out uint)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.Size.get
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.GetView()
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.GetAt(uint)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.SetAt(uint, Microsoft.UI.Composition.Scenes.SceneComponent)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.InsertAt(uint, Microsoft.UI.Composition.Scenes.SceneComponent)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.RemoveAt(uint)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.Append(Microsoft.UI.Composition.Scenes.SceneComponent)
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.RemoveAtEnd()
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.Clear()
		// Forced skipping of method Microsoft.UI.Composition.Scenes.SceneComponentCollection.ReplaceAll(Microsoft.UI.Composition.Scenes.SceneComponent[])
		// Processing: System.Collections.Generic.IList<Microsoft.UI.Composition.Scenes.SceneComponent>
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int IndexOf( global::Microsoft.UI.Composition.Scenes.SceneComponent item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Insert( int index,  global::Microsoft.UI.Composition.Scenes.SceneComponent item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IList<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void RemoveAt( int index)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Microsoft.UI.Composition.Scenes.SceneComponent this[int index]
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		// Processing: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Add( global::Microsoft.UI.Composition.Scenes.SceneComponent item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Contains( global::Microsoft.UI.Composition.Scenes.SceneComponent item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void CopyTo( global::Microsoft.UI.Composition.Scenes.SceneComponent[] array,  int arrayIndex)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.ICollection<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Remove( global::Microsoft.UI.Composition.Scenes.SceneComponent item)
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int Count
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsReadOnly
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}
		#endif
		// Processing: System.Collections.Generic.IEnumerable<Microsoft.UI.Composition.Scenes.SceneComponent>
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Microsoft.UI.Composition.Scenes.SceneComponent>
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IEnumerator<global::Microsoft.UI.Composition.Scenes.SceneComponent> GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: System.Collections.IEnumerable
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.IEnumerable
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		 global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
	}
}
