﻿namespace FlightPhysics.UI
{
    public class ProgressManager : Singleton<ProgressManager>
    {
        public TrackProgress TrackP;
        public TimeProgress TimeP;
        public GateProgress GateP;

        protected override void Awake()
        {
            base.Awake();

            TrackP = GetComponentInChildren<TrackProgress>();
            GateP = GetComponentInChildren<GateProgress>();
        }

    }

}