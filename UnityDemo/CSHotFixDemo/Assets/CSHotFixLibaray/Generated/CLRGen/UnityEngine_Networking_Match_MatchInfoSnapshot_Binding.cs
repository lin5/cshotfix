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
    unsafe class UnityEngine_Networking_Match_MatchInfoSnapshot_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.Match.MatchInfoSnapshot);
            args = new Type[]{};
            method = type.GetMethod("get_networkId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_networkId_0);
            args = new Type[]{};
            method = type.GetMethod("get_hostNodeId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hostNodeId_1);
            args = new Type[]{};
            method = type.GetMethod("get_name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_name_2);
            args = new Type[]{};
            method = type.GetMethod("get_averageEloScore", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_averageEloScore_3);
            args = new Type[]{};
            method = type.GetMethod("get_maxSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxSize_4);
            args = new Type[]{};
            method = type.GetMethod("get_currentSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentSize_5);
            args = new Type[]{};
            method = type.GetMethod("get_isPrivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPrivate_6);
            args = new Type[]{};
            method = type.GetMethod("get_matchAttributes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_matchAttributes_7);
            args = new Type[]{};
            method = type.GetMethod("get_directConnectInfos", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_directConnectInfos_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.Match.MatchInfoSnapshot());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.Match.MatchInfoSnapshot[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_networkId_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.networkId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hostNodeId_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hostNodeId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_name_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.name;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_averageEloScore_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.averageEloScore;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxSize_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_currentSize_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_isPrivate_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isPrivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_matchAttributes_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.matchAttributes;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_directConnectInfos_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.MatchInfoSnapshot instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.MatchInfoSnapshot)typeof(UnityEngine.Networking.Match.MatchInfoSnapshot).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.directConnectInfos;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.Match.MatchInfoSnapshot();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
