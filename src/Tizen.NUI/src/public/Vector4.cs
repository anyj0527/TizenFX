//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI
{

    /// <summary>
    /// A four dimensional vector.
    /// </summary>
    public class Vector4 : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Vector4(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector4 obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //NUI Dispose Pattern written by Jinwoo Nam(jjw.nam) 

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;

        ~Vector4()
        {
            if(!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Vector4(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            disposed = true;
        }

        /// <summary>
        /// Addition operator.
        /// </summary>
        /// <param name="arg1">First value</param>
        /// <param name="arg2">Second value</param>
        /// <returns>A vector containing the result of the addition</returns>
        public static Vector4 operator +(Vector4 arg1, Vector4 arg2)
        {
            return arg1.Add(arg2);
        }

        /// <summary>
        /// Subtraction operator.
        /// </summary>
        /// <param name="arg1">First value</param>
        /// <param name="arg2">Second value</param>
        /// <returns>A vector containing the result of the subtraction</returns>
        public static Vector4 operator -(Vector4 arg1, Vector4 arg2)
        {
            return arg1.Subtract(arg2);
        }

        /// <summary>
        /// Unary negation operator.
        /// </summary>
        /// <param name="arg1">Target Value</param>
        /// <returns>A vector containg the negation</returns>
        public static Vector4 operator -(Vector4 arg1)
        {
            return arg1.Subtract();
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the multiplication</returns>
        public static Vector4 operator *(Vector4 arg1, Vector4 arg2)
        {
            return arg1.Multiply(arg2);
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">The float value to scale the vector</param>
        /// <returns>A vector containing the result of the scaling</returns>
        public static Vector4 operator *(Vector4 arg1, float arg2)
        {
            return arg1.Multiply(arg2);
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A vector containing the result of the division</returns>
        public static Vector4 operator /(Vector4 arg1, Vector4 arg2)
        {
            return arg1.Divide(arg2);
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">The float value to scale the vector by</param>
        /// <returns>A vector containing the result of the scaling</returns>
        public static Vector4 operator /(Vector4 arg1, float arg2)
        {
            return arg1.Divide(arg2);
        }

        /// <summary>
        /// Array subscript operator overload.
        /// </summary>
        /// <param name="index">Subscript index</param>
        /// <returns>The float at the given index</returns>
        public float this[uint index]
        {
            get
            {
                return ValueOfIndex(index);
            }
        }

        internal static Vector4 GetVector4FromPtr(global::System.IntPtr cPtr)
        {
            Vector4 ret = new Vector4(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Default constructor, initializes the vector to 0.
        /// </summary>
        public Vector4() : this(NDalicPINVOKE.new_Vector4__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from four floats.
        /// </summary>
        /// <param name="x">x (or r/s) component</param>
        /// <param name="y">y (or g/t) component</param>
        /// <param name="z">z (or b/p) component</param>
        /// <param name="w">w (or a/q) component</param>
        public Vector4(float x, float y, float z, float w) : this(NDalicPINVOKE.new_Vector4__SWIG_1(x, y, z, w), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from an array of four floats.
        /// </summary>
        /// <param name="array">array Array of either xyzw/rgba/stpq</param>
        public Vector4(float[] array) : this(NDalicPINVOKE.new_Vector4__SWIG_2(array), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from Vector2.
        /// </summary>
        /// <param name="vec2">Vector2 to copy from, z and w are initialized to 0</param>
        public Vector4(Vector2 vec2) : this(NDalicPINVOKE.new_Vector4__SWIG_3(Vector2.getCPtr(vec2)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from Vector3.
        /// </summary>
        /// <param name="vec3">Vector3 to copy from, w is initialized to 0</param>
        public Vector4(Vector3 vec3) : this(NDalicPINVOKE.new_Vector4__SWIG_4(Vector3.getCPtr(vec3)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// (1.0f,1.0f,1.0f,1.0f)
        /// </summary>
        public static Vector4 One
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ONE_get();
                Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// (1.0f,0.0f,0.0f,0.0f)
        /// </summary>
        public static Vector4 XAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_XAXIS_get();
                Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// (0.0f,1.0f,0.0f,0.0f)
        /// </summary>
        public static Vector4 YAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_YAXIS_get();
                Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// (0.0f,0.0f,1.0f,0.0f)
        /// </summary>
        public static Vector4 ZAxis
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ZAXIS_get();
                Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// (0.0f, 0.0f, 0.0f, 0.0f)
        /// </summary>
        public static Vector4 Zero
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ZERO_get();
                Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private Vector4 Add(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Add(swigCPtr, Vector4.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 AddAssign(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_AddAssign(swigCPtr, Vector4.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Subtract(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Subtract__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 SubtractAssign(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_SubtractAssign(swigCPtr, Vector4.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Multiply(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Multiply__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Multiply(float rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Multiply__SWIG_1(swigCPtr, rhs), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 MultiplyAssign(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 MultiplyAssign(float rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Divide(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Divide__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Divide(float rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Divide__SWIG_1(swigCPtr, rhs), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 DivideAssign(Vector4 rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_DivideAssign__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 DivideAssign(float rhs)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_DivideAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Vector4 Subtract()
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Subtract__SWIG_1(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool EqualTo(Vector4 rhs)
        {
            bool ret = NDalicPINVOKE.Vector4_EqualTo(swigCPtr, Vector4.getCPtr(rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private bool NotEqualTo(Vector4 rhs)
        {
            bool ret = NDalicPINVOKE.Vector4_NotEqualTo(swigCPtr, Vector4.getCPtr(rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private float ValueOfIndex(uint index)
        {
            float ret = NDalicPINVOKE.Vector4_ValueOfIndex__SWIG_0(swigCPtr, index);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot(Vector3 other)
        {
            float ret = NDalicPINVOKE.Vector4_Dot__SWIG_0(swigCPtr, Vector3.getCPtr(other));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot(Vector4 other)
        {
            float ret = NDalicPINVOKE.Vector4_Dot__SWIG_1(swigCPtr, Vector4.getCPtr(other));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal float Dot4(Vector4 other)
        {
            float ret = NDalicPINVOKE.Vector4_Dot4(swigCPtr, Vector4.getCPtr(other));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Vector4 Cross(Vector4 other)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Cross(swigCPtr, Vector4.getCPtr(other)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the length of the vector.
        /// </summary>
        /// <returns>The length</returns>
        public float Length()
        {
            float ret = NDalicPINVOKE.Vector4_Length(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Returns the length of the vector squared.<br>
        /// This is faster than using Length() when performing
        /// threshold checks as it avoids use of the square root.<br>
        /// </summary>
        /// <returns>The length of the vector squared</returns>
        public float LengthSquared()
        {
            float ret = NDalicPINVOKE.Vector4_LengthSquared(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Normalizes the vector.<br>
        /// Sets the vector to unit length whilst maintaining its direction.<br>
        /// </summary>
        public void Normalize()
        {
            NDalicPINVOKE.Vector4_Normalize(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Clamps the vector between minimum and maximum vectors.
        /// </summary>
        /// <param name="min">The minimum vector</param>
        /// <param name="max">The maximum vector</param>
        public void Clamp(Vector4 min, Vector4 max)
        {
            NDalicPINVOKE.Vector4_Clamp(swigCPtr, Vector4.getCPtr(min), Vector4.getCPtr(max));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal SWIGTYPE_p_float AsFloat()
        {
            global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_AsFloat__SWIG_0(swigCPtr);
            SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// x component
        /// </summary>
        public float X
        {
            set
            {
                NDalicPINVOKE.Vector4_X_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_X_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// red component
        /// </summary>
        public float R
        {
            set
            {
                NDalicPINVOKE.Vector4_r_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_r_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// s component
        /// </summary>
        public float S
        {
            set
            {
                NDalicPINVOKE.Vector4_s_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_s_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// y component
        /// </summary>
        public float Y
        {
            set
            {
                NDalicPINVOKE.Vector4_Y_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_Y_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// green component
        /// </summary>
        public float G
        {
            set
            {
                NDalicPINVOKE.Vector4_g_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_g_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// t component
        /// </summary>
        public float T
        {
            set
            {
                NDalicPINVOKE.Vector4_t_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_t_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// z component
        /// </summary>
        public float Z
        {
            set
            {
                NDalicPINVOKE.Vector4_Z_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_Z_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// blue component
        /// </summary>
        public float B
        {
            set
            {
                NDalicPINVOKE.Vector4_b_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_b_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// p component
        /// </summary>
        public float P
        {
            set
            {
                NDalicPINVOKE.Vector4_p_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_p_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// w component
        /// </summary>
        public float W
        {
            set
            {
                NDalicPINVOKE.Vector4_W_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_W_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// alpha component
        /// </summary>
        public float A
        {
            set
            {
                NDalicPINVOKE.Vector4_a_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_a_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// q component
        /// </summary>
        public float Q
        {
            set
            {
                NDalicPINVOKE.Vector4_q_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_q_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

    }

}
