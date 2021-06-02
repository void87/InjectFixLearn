/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Test {
    //HelloworldCfg.cs里配置了这个类型
    public class Calculator {
        //修改成正确的逻辑后，打开如下注释，生成的补丁将修正该函数

        // 错误的版本
        public int Add(int a, int b) {
            return a * b;
        }

        //// 正确的版本,添加 [IFix.Patch]
        //// PatchManager.Load() 加载完补丁后, 会执行下面正确的代码
        //[Patch]
        //public int Add(int a, int b) {
        //    UnityEngine.Debug.Log("patchNewValue: " + patchNewValue);
        //    UnityEngine.Debug.Log("patchNewProperty: " + patchNewProperty);

        //    PatchNewMethod();

        //    PatchNewClass patchNewClass = new PatchNewClass();
        //    patchNewClass.Test1();

        //    // 修复了错误的代码
        //    return a + b;
        //}

        //[IFix.Interpret]
        //public int patchNewValue = 0;

        //[IFix.Interpret]
        //public int patchNewProperty {
        //    get; set;
        //} = 2;

        //[IFix.Interpret]
        //public void PatchNewMethod() {
        //    UnityEngine.Debug.Log("PatchNewMethod");
        //}

        //[IFix.Interpret]
        //public class PatchNewClass {
        //    public void Test1() {
        //        UnityEngine.Debug.Log("PatchNewClass.Test1()");
        //    }
        //}




        public int Sub(int a, int b) {
            return a / b;
        }

        public int Mult(int a, int b) {
            return a * b;
        }

        public int Div(int a, int b) {
            return a / b;
        }
    }
}
