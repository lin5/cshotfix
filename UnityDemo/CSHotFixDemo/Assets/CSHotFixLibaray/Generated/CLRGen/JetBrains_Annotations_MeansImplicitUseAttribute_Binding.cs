﻿
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class JetBrains_Annotations_MeansImplicitUseAttribute_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(JetBrains.Annotations.MeansImplicitUseAttribute);
            args = new Type[]{};
            method = type.GetMethod("get_UseKindFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UseKindFlags_0);
            args = new Type[]{};
            method = type.GetMethod("get_TargetFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TargetFlags_1);



            app.RegisterCLRCreateDefaultInstance(type, () => new JetBrains.Annotations.MeansImplicitUseAttribute());
            app.RegisterCLRCreateArrayInstance(type, s => new JetBrains.Annotations.MeansImplicitUseAttribute[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(JetBrains.Annotations.ImplicitUseKindFlags)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(JetBrains.Annotations.ImplicitUseTargetFlags)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);
            args = new Type[]{typeof(JetBrains.Annotations.ImplicitUseKindFlags), typeof(JetBrains.Annotations.ImplicitUseTargetFlags)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_3);

        }


        static StackObject* get_UseKindFlags_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JetBrains.Annotations.MeansImplicitUseAttribute instance_of_this_method;
            instance_of_this_method = (JetBrains.Annotations.MeansImplicitUseAttribute)typeof(JetBrains.Annotations.MeansImplicitUseAttribute).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UseKindFlags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_TargetFlags_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JetBrains.Annotations.MeansImplicitUseAttribute instance_of_this_method;
            instance_of_this_method = (JetBrains.Annotations.MeansImplicitUseAttribute)typeof(JetBrains.Annotations.MeansImplicitUseAttribute).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TargetFlags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new JetBrains.Annotations.MeansImplicitUseAttribute();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JetBrains.Annotations.ImplicitUseKindFlags useKindFlags = (JetBrains.Annotations.ImplicitUseKindFlags)typeof(JetBrains.Annotations.ImplicitUseKindFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new JetBrains.Annotations.MeansImplicitUseAttribute(useKindFlags);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JetBrains.Annotations.ImplicitUseTargetFlags targetFlags = (JetBrains.Annotations.ImplicitUseTargetFlags)typeof(JetBrains.Annotations.ImplicitUseTargetFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new JetBrains.Annotations.MeansImplicitUseAttribute(targetFlags);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            JetBrains.Annotations.ImplicitUseTargetFlags targetFlags = (JetBrains.Annotations.ImplicitUseTargetFlags)typeof(JetBrains.Annotations.ImplicitUseTargetFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            JetBrains.Annotations.ImplicitUseKindFlags useKindFlags = (JetBrains.Annotations.ImplicitUseKindFlags)typeof(JetBrains.Annotations.ImplicitUseKindFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new JetBrains.Annotations.MeansImplicitUseAttribute(useKindFlags, targetFlags);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
