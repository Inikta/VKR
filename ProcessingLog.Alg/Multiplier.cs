﻿using IProcessingLog;
using ProcessingLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLog.Alg
{
    public delegate double MultiplierFucntion(double x);

    class Multiplier(MultiplierFucntion del) : IAlgorythm
    {
        public Curve[] ChangedCurves { get; private set; } = [];
        private MultiplierFucntion FuncDelegate { get; } = del;

        public void Process(Curve[] inputCurves, IndexRange[] inputChanges, 
                            Parameter[] inputParameters, (string, bool)[] param_chng_status, Curve[] outputCurves,
                            IndexRange[] outputChanges)
        {
            ChangedCurves = (Curve[])outputCurves.Clone();
            int rangeIdx = 0;

            foreach (Curve curve in inputCurves)
            {
                for (int i = inputChanges[rangeIdx].Range.start; i < inputChanges[rangeIdx].Range.end; i++)
                {
                    ChangedCurves[rangeIdx].Value[i] = FuncDelegate(curve.Value[i]);
                }

                rangeIdx++;
            }
        }

        public Curve[] GetCurves()
        {
            return ChangedCurves;
        }

        public int CountInputCurves => throw new NotImplementedException();

        public int CountInputParameters => throw new NotImplementedException();

        public int CountOutputCurves => throw new NotImplementedException();       
    }
}
