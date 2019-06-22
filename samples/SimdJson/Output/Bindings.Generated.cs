﻿// This file is auto-generated. Do not edit.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace SimdJsonSharp
{
﻿    public unsafe partial class padded_string : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Handle
        /// <summary>
        /// Pointer to the underlying native object
        /// </summary>
        public IntPtr Handle => DangerousGetHandle();

        /// <summary>
        /// Create padded_string from a native pointer
        /// ownsHandle=false means GC won't delete the underlying native object if this C# wrapper goes out of scope
        /// </summary>
        public padded_string(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) => SetHandle(handle);
        #endregion

        #region API
//TODO: %API%
        #endregion

        #region DllImports
        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr padded_string_padded_string0();

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr padded_string_padded_string1(IntPtr/*size_t*/ length);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr padded_string_padded_string2(SByte* data, IntPtr/*size_t*/ length);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr padded_string_padded_string5(IntPtr o);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void padded_string_swap6(IntPtr target, IntPtr o);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ padded_string_size7(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ padded_string_length8(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern SByte* padded_string_data9(IntPtr target);
        #endregion

        #region ReleaseHandle
        protected override bool ReleaseHandle()
        {
            padded_string__delete(Handle);
            return true;
        }

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void padded_string__delete(IntPtr target);
        #endregion
    }

﻿    public unsafe partial class ParsedJson : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Handle
        /// <summary>
        /// Pointer to the underlying native object
        /// </summary>
        public IntPtr Handle => DangerousGetHandle();

        /// <summary>
        /// Create ParsedJson from a native pointer
        /// ownsHandle=false means GC won't delete the underlying native object if this C# wrapper goes out of scope
        /// </summary>
        public ParsedJson(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) => SetHandle(handle);
        #endregion

        #region API
//TODO: %API%
        #endregion

        #region DllImports
        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ParsedJson_ParsedJson0();

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ParsedJson_ParsedJson2(IntPtr p);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte ParsedJson_allocateCapacity3(IntPtr target, IntPtr/*size_t*/ len, IntPtr/*size_t*/ maxdepth);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte ParsedJson_isValid4(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_deallocate5(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_init6(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_write_tape9(IntPtr target, UInt64 val, Byte c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_write_tape_s6410(IntPtr target, Int64 i);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_write_tape_double11(IntPtr target, Double d);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 ParsedJson_get_current_loc12(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson_annotate_previousloc13(IntPtr target, UInt32 saved_loc, UInt64 val);
        #endregion

        #region ReleaseHandle
        protected override bool ReleaseHandle()
        {
            ParsedJson__delete(Handle);
            return true;
        }

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void ParsedJson__delete(IntPtr target);
        #endregion
    }

﻿    public unsafe partial class InvalidJSON : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Handle
        /// <summary>
        /// Pointer to the underlying native object
        /// </summary>
        public IntPtr Handle => DangerousGetHandle();

        /// <summary>
        /// Create InvalidJSON from a native pointer
        /// ownsHandle=false means GC won't delete the underlying native object if this C# wrapper goes out of scope
        /// </summary>
        public InvalidJSON(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) => SetHandle(handle);
        #endregion

        #region API
//TODO: %API%
        #endregion

        #region DllImports
        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern SByte* InvalidJSON_what0(IntPtr target);
        #endregion

        #region ReleaseHandle
        protected override bool ReleaseHandle()
        {
            InvalidJSON__delete(Handle);
            return true;
        }

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void InvalidJSON__delete(IntPtr target);
        #endregion
    }

﻿    public unsafe partial class iterator : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Handle
        /// <summary>
        /// Pointer to the underlying native object
        /// </summary>
        public IntPtr Handle => DangerousGetHandle();

        /// <summary>
        /// Create iterator from a native pointer
        /// ownsHandle=false means GC won't delete the underlying native object if this C# wrapper goes out of scope
        /// </summary>
        public iterator(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) => SetHandle(handle);
        #endregion

        #region API
//TODO: %API%
        #endregion

        #region DllImports
        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr iterator_iterator0(IntPtr pj_);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr iterator_iterator1(IntPtr o);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_isOk3(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ iterator_get_tape_location4(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ iterator_get_tape_length5(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ iterator_get_depth6(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_get_scope_type7(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_move_forward8(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_get_type9(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int64 iterator_get_integer10(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern SByte* iterator_get_string11(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 iterator_get_string_length12(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Double iterator_get_double13(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_object_or_array14(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_object15(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_array16(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_string17(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_integer18(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_double19(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_true20(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_false21(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_null22(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_is_object_or_array23(Byte type);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_move_to_key24(IntPtr target, SByte* key);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_next25(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_prev26(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_up27(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte iterator_down28(IntPtr target);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void iterator_to_start_scope29(IntPtr target);
        #endregion

        #region ReleaseHandle
        protected override bool ReleaseHandle()
        {
            iterator__delete(Handle);
            return true;
        }

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void iterator__delete(IntPtr target);
        #endregion
    }

﻿    public unsafe partial class scopeindex_t : SafeHandleZeroOrMinusOneIsInvalid
    {
        #region Handle
        /// <summary>
        /// Pointer to the underlying native object
        /// </summary>
        public IntPtr Handle => DangerousGetHandle();

        /// <summary>
        /// Create scopeindex_t from a native pointer
        /// ownsHandle=false means GC won't delete the underlying native object if this C# wrapper goes out of scope
        /// </summary>
        public scopeindex_t(IntPtr handle, bool ownsHandle = true) : base(ownsHandle) => SetHandle(handle);
        #endregion

        #region API
//TODO: %API%
        #endregion

        #region DllImports

        #endregion

        #region ReleaseHandle
        protected override bool ReleaseHandle()
        {
            scopeindex_t__delete(Handle);
            return true;
        }

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void scopeindex_t__delete(IntPtr target);
        #endregion
    }

﻿    public unsafe static partial class GlobalFunctions
    {
        #region DllImports
        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _add_overflow0(UInt64 value1, UInt64 value2, UInt64* result);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _mul_overflow1(UInt64 value1, UInt64 value2, UInt64* result);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _trailingzeroes2(UInt64 input_num);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _leadingzeroes3(UInt64 input_num);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _hamming4(UInt64 input_num);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void* _aligned_malloc5(IntPtr/*size_t*/ alignment, IntPtr/*size_t*/ size);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern SByte* _aligned_malloc_char6(IntPtr/*size_t*/ alignment, IntPtr/*size_t*/ size);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void _aligned_free7(void* memblock);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void _aligned_free_char8(SByte* memblock);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern SByte* _allocate_padded_buffer9(IntPtr/*size_t*/ length);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 _is_not_structural_or_whitespace10(Byte c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 _is_structural_or_whitespace11(Byte c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern UInt32 _hex_to_u32_nocheck12(Byte* src);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ _codepoint_to_utf813(UInt32 cp, Byte* c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void _print_with_escapes14(Byte* src);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void _print_with_escapes16(Byte* src, IntPtr/*size_t*/ len);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ _jsonminify21(Byte* buf, IntPtr/*size_t*/ len, Byte* @out);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ _jsonminify22(SByte* buf, IntPtr/*size_t*/ len, SByte* @out);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr/*size_t*/ _jsonminify24(IntPtr p, SByte* @out);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _find_structural_bits27(Byte* buf, IntPtr/*size_t*/ len, IntPtr pj);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _find_structural_bits28(SByte* buf, IntPtr/*size_t*/ len, IntPtr pj);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _handle_unicode_codepoint29(Byte* src_ptr, Byte* dst_ptr);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _parse_string30(Byte* buf, IntPtr/*size_t*/ len, IntPtr pj, UInt32 depth, UInt32 offset);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _is_integer31(SByte c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _is_not_structural_or_whitespace_or_exponent_or_decimal_or_null32(Byte c);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _parse_float33(Byte* buf, IntPtr pj, UInt32 offset, Byte found_minus);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _parse_large_integer34(Byte* buf, IntPtr pj, UInt32 offset, Byte found_minus);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Byte _parse_number35(Byte* buf, IntPtr pj, UInt32 offset, Byte found_minus);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern void _init_state_machine36();

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _unified_machine37(Byte* buf, IntPtr/*size_t*/ len, IntPtr pj);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _unified_machine38(SByte* buf, IntPtr/*size_t*/ len, IntPtr pj);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _json_parse39(Byte* buf, IntPtr/*size_t*/ len, IntPtr pj, Byte reallocifneeded);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _json_parse40(SByte* buf, IntPtr/*size_t*/ len, IntPtr pj, Byte reallocifneeded);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 _json_parse42(IntPtr s, IntPtr pj);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr _build_parsed_json43(Byte* buf, IntPtr/*size_t*/ len, Byte reallocifneeded);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr _build_parsed_json44(SByte* buf, IntPtr/*size_t*/ len, Byte reallocifneeded);

        [DllImport(SimdJsonN.NativeLib, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr _build_parsed_json46(IntPtr s);
        #endregion
    }
}
