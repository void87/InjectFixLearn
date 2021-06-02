/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Conv_Ovf_I1,
        Brfalse,
        Stind_I4,
        Endfilter,
        Starg,
        Ldind_I8,
        Brtrue,
        Box,
        Nop,
        Neg,
        Conv_Ovf_I4_Un,
        Conv_Ovf_I2_Un,
        Sub,
        Callvirtvirt,
        Volatile,
        Ldind_U4,
        Callvirt,
        Mul,
        Ldloca,
        Ldc_R8,
        Unbox_Any,
        Ldlen,
        Conv_I4,
        Stind_Ref,
        Throw,
        Ldvirtftn,
        Unaligned,
        Stobj,
        Or,
        Ble,
        Ldind_I1,
        Ldsfld,
        Conv_U,
        Dup,
        Localloc,
        Ldind_R4,
        Conv_Ovf_I,
        Conv_I1,
        Ldc_R4,
        Stsfld,
        Stind_I8,
        Div,
        Conv_U8,
        Conv_Ovf_U4,
        Conv_U1,
        Stelem_I8,
        Bge,
        Ldind_U2,

        //Pseudo instruction
        StackSpace,
        Ldarg,
        Ceq,
        Stelem_I4,
        Add_Ovf_Un,
        Ldftn,
        Bne_Un,
        Ldelem_Any,
        Ldelem_Ref,
        Readonly,
        Bgt,
        Ldind_Ref,
        Call,
        Initblk,
        Conv_I2,
        Conv_Ovf_I_Un,
        Ldtype, // custom
        Ldelema,
        Rem,
        Conv_I,
        Conv_U4,
        Stelem_Ref,
        Shr_Un,
        Ldind_I,
        Conv_U2,
        Conv_Ovf_I2,
        Stind_R4,
        Ldind_I2,
        Stelem_R4,
        Xor,
        Jmp,
        Stloc,
        Ldelem_I2,
        Ldelem_U4,
        Rem_Un,
        Add_Ovf,
        Ldloc,
        Ldc_I8,
        Newarr,
        Conv_Ovf_U4_Un,
        Cgt,
        Stind_I,
        Conv_Ovf_I1_Un,
        Ldind_I4,
        Bgt_Un,
        Stfld,
        Shl,
        Stelem_I,
        Castclass,
        Stind_R8,
        Ldind_R8,
        Blt,
        Clt,
        Ldelem_U1,
        Stelem_R8,
        Tail,
        Ldelem_I8,
        Pop,
        Cgt_Un,
        Conv_Ovf_U1,
        Leave,
        Rethrow,
        Sizeof,
        Ldelem_I,
        Sub_Ovf,
        Ldflda,
        Constrained,
        Conv_Ovf_U8,
        Ldnull,
        Ldelem_R4,
        Cpobj,
        Conv_R4,
        Ret,
        Newobj,
        Conv_Ovf_U2,
        Ckfinite,
        Blt_Un,
        Ldfld,
        Ldsflda,
        No,
        Shr,
        Initobj,
        Conv_Ovf_U,
        Not,
        Mul_Ovf_Un,
        Switch,
        Ldelem_I4,
        Ldelem_U2,
        Break,
        Newanon,
        Conv_Ovf_U1_Un,
        Conv_Ovf_I8_Un,
        Conv_Ovf_U8_Un,
        Stind_I1,
        Clt_Un,
        Stind_I2,
        Conv_R_Un,
        Refanyval,
        //Calli,
        Ldc_I4,
        And,
        Beq,
        Add,
        Cpblk,
        Ldarga,
        Ble_Un,
        Ldstr,
        Conv_Ovf_U2_Un,
        Conv_I8,
        Conv_Ovf_I8,
        Ldvirtftn2,
        Ldobj,
        Refanytype,
        Isinst,
        Endfinally,
        Unbox,
        Mul_Ovf,
        Ldelem_I1,
        Sub_Ovf_Un,
        Bge_Un,
        Ldtoken,
        Br,
        CallExtern,
        Conv_R8,
        Arglist,
        Stelem_I2,
        Mkrefany,
        Stelem_I1,
        Div_Un,
        Stelem_Any,
        Ldelem_R8,
        Conv_Ovf_I4,
        Ldind_U1,
        Conv_Ovf_U_Un,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 2921868253832700472;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}