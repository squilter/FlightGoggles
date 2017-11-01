/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace agile
{
    public sealed class runStats_t : LCM.LCM.LCMEncodable
    {
        public long timestamp;
        public int iterationNum;
        public int stepNum;
        public short numLogs;
        public String[] name;
        public double[] maxError;
        public double[] maxTime;
 
        public runStats_t()
        {
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x9d07f4c26993ebf0L;
 
        static runStats_t()
        {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("agile.runStats_t"))
                return 0L;
 
            classes.Add("agile.runStats_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(LCMDataOutputStream outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(LCMDataOutputStream outs)
        {
            byte[] __strbuf = null;
            outs.Write(this.timestamp); 
 
            outs.Write(this.iterationNum); 
 
            outs.Write(this.stepNum); 
 
            outs.Write(this.numLogs); 
 
            for (int a = 0; a < this.numLogs; a++) {
                __strbuf = System.Text.Encoding.GetEncoding("US-ASCII").GetBytes(this.name[a]); outs.Write(__strbuf.Length+1); outs.Write(__strbuf, 0, __strbuf.Length); outs.Write((byte) 0); 
            }
 
            for (int a = 0; a < this.numLogs; a++) {
                outs.Write(this.maxError[a]); 
            }
 
            for (int a = 0; a < this.numLogs; a++) {
                outs.Write(this.maxTime[a]); 
            }
 
        }
 
        public runStats_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public runStats_t(LCMDataInputStream ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static agile.runStats_t _decodeRecursiveFactory(LCMDataInputStream ins)
        {
            agile.runStats_t o = new agile.runStats_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(LCMDataInputStream ins)
        {
            byte[] __strbuf = null;
            this.timestamp = ins.ReadInt64();
 
            this.iterationNum = ins.ReadInt32();
 
            this.stepNum = ins.ReadInt32();
 
            this.numLogs = ins.ReadInt16();
 
            this.name = new String[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                __strbuf = new byte[ins.ReadInt32()-1]; ins.ReadFully(__strbuf); ins.ReadByte(); this.name[a] = System.Text.Encoding.GetEncoding("US-ASCII").GetString(__strbuf);
            }
 
            this.maxError = new double[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                this.maxError[a] = ins.ReadDouble();
            }
 
            this.maxTime = new double[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                this.maxTime[a] = ins.ReadDouble();
            }
 
        }
 
        public agile.runStats_t Copy()
        {
            agile.runStats_t outobj = new agile.runStats_t();
            outobj.timestamp = this.timestamp;
 
            outobj.iterationNum = this.iterationNum;
 
            outobj.stepNum = this.stepNum;
 
            outobj.numLogs = this.numLogs;
 
            outobj.name = new String[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                outobj.name[a] = this.name[a];
            }
 
            outobj.maxError = new double[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                outobj.maxError[a] = this.maxError[a];
            }
 
            outobj.maxTime = new double[(int) numLogs];
            for (int a = 0; a < this.numLogs; a++) {
                outobj.maxTime[a] = this.maxTime[a];
            }
 
            return outobj;
        }
    }
}
