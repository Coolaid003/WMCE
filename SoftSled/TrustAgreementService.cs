using Intel.UPNP;
using SoftSled.Components;

namespace SoftSled
{
    /// <summary>
    /// Transparent DeviceSide UPnP Service
    /// </summary>
    public class TrustAgreementService : IUPnPService
    {
        private Logger m_logger;
        // Place your declarations above this line

        public TrustAgreementService(Logger logger) : this()
        {
            m_logger = logger;
        }

        #region AutoGenerated Code Section [Do NOT Modify, unless you know what you're doing]
        //{{{{{ Begin Code Block

        private _TrustAgreementService _S;
        public static string URN = "urn:schemas-microsoft-com:service:mstrustagreement:1";
        public double VERSION
        {
            get
            {
                return (double.Parse(_S.GetUPnPService().Version));
            }
        }

        public delegate void OnStateVariableModifiedHandler(TrustAgreementService sender);
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_EndpointID;
        public event OnStateVariableModifiedHandler OnStateVariableModified_TrustState;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Rounds;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Nonce;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Authenticator;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Certificate;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Iteration;
        public System.String A_ARG_TYPE_EndpointID
        {
            get
            {
                return ((System.String)_S.GetStateVariable("A_ARG_TYPE_EndpointID"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_EndpointID", value);
            }
        }
        public System.Byte TrustState
        {
            get
            {
                return ((System.Byte)_S.GetStateVariable("TrustState"));
            }
            set
            {
                _S.SetStateVariable("TrustState", value);
            }
        }
        public System.Byte A_ARG_TYPE_Rounds
        {
            get
            {
                return ((System.Byte)_S.GetStateVariable("A_ARG_TYPE_Rounds"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_Rounds", value);
            }
        }
        public System.String A_ARG_TYPE_Nonce
        {
            get
            {
                return ((System.String)_S.GetStateVariable("A_ARG_TYPE_Nonce"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_Nonce", value);
            }
        }
        public System.String A_ARG_TYPE_Authenticator
        {
            get
            {
                return ((System.String)_S.GetStateVariable("A_ARG_TYPE_Authenticator"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_Authenticator", value);
            }
        }
        public System.String A_ARG_TYPE_Certificate
        {
            get
            {
                return ((System.String)_S.GetStateVariable("A_ARG_TYPE_Certificate"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_Certificate", value);
            }
        }
        public System.Byte A_ARG_TYPE_Iteration
        {
            get
            {
                return ((System.Byte)_S.GetStateVariable("A_ARG_TYPE_Iteration"));
            }
            set
            {
                _S.SetStateVariable("A_ARG_TYPE_Iteration", value);
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_EndpointID
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_EndpointID
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_TrustState
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).Accumulator = value;
            }
        }
        public double ModerationDuration_TrustState
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Rounds
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Rounds
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Nonce
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Nonce
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Authenticator
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Authenticator
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Certificate
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Certificate
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Iteration
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).Accumulator);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Iteration
        {
            get
            {
                return (((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).ModerationPeriod);
            }
            set
            {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).ModerationPeriod = value;
            }
        }
        public delegate void Delegate_Commit(System.String HostID, System.Byte Iteration, System.String HostValidateAuthenticator, out System.String DeviceValidateAuthenticator);
        public delegate void Delegate_Confirm(System.String HostID, System.Byte IterationsRequired, System.String HostConfirmNonce, out System.String DeviceConfirmNonce);
        public delegate void Delegate_Exchange(System.String HostID, System.String HostCertificate, System.Byte IterationsRequired, System.String HostConfirmAuthenticator, out System.String DeviceID, out System.String DeviceCertificate, out System.String DeviceConfirmAuthenticator);
        public delegate void Delegate_Validate(System.String HostID, System.Byte Iteration, System.String HostValidateNonce, out System.String DeviceValidateNonce);

        public Delegate_Commit External_Commit = null;
        public Delegate_Confirm External_Confirm = null;
        public Delegate_Exchange External_Exchange = null;
        public Delegate_Validate External_Validate = null;

        public void RemoveStateVariable_A_ARG_TYPE_EndpointID()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID"));
        }
        public void RemoveStateVariable_TrustState()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("TrustState"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Rounds()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Nonce()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Authenticator()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Certificate()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Iteration()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration"));
        }
        public void RemoveAction_Commit()
        {
            _S.GetUPnPService().RemoveMethod("Commit");
        }
        public void RemoveAction_Confirm()
        {
            _S.GetUPnPService().RemoveMethod("Confirm");
        }
        public void RemoveAction_Exchange()
        {
            _S.GetUPnPService().RemoveMethod("Exchange");
        }
        public void RemoveAction_Validate()
        {
            _S.GetUPnPService().RemoveMethod("Validate");
        }
        public System.Net.IPEndPoint GetCaller()
        {
            return (_S.GetUPnPService().GetCaller());
        }
        public System.Net.IPEndPoint GetReceiver()
        {
            return (_S.GetUPnPService().GetReceiver());
        }

        private class _TrustAgreementService
        {
            private TrustAgreementService Outer = null;
            private UPnPService S;
            internal _TrustAgreementService(TrustAgreementService n)
            {
                Outer = n;
                S = BuildUPnPService();
            }
            public UPnPService GetUPnPService()
            {
                return (S);
            }
            public void SetStateVariable(string VarName, object VarValue)
            {
                S.SetStateVariable(VarName, VarValue);
            }
            public object GetStateVariable(string VarName)
            {
                return (S.GetStateVariable(VarName));
            }
            protected UPnPService BuildUPnPService()
            {
                UPnPStateVariable[] RetVal = new UPnPStateVariable[7];
                RetVal[0] = new UPnPModeratedStateVariable("A_ARG_TYPE_EndpointID", typeof(System.String), false);
                RetVal[0].AddAssociation("Commit", "HostID");
                RetVal[0].AddAssociation("Confirm", "HostID");
                RetVal[0].AddAssociation("Exchange", "HostID");
                RetVal[0].AddAssociation("Exchange", "DeviceID");
                RetVal[0].AddAssociation("Validate", "HostID");
                RetVal[1] = new UPnPModeratedStateVariable("TrustState", typeof(System.Byte), false);
                RetVal[1].SetRange((System.Byte)(0), (System.Byte)(4), null);
                RetVal[2] = new UPnPModeratedStateVariable("A_ARG_TYPE_Rounds", typeof(System.Byte), false);
                RetVal[2].SetRange((System.Byte)(2), (System.Byte)(20), null);
                RetVal[2].AddAssociation("Confirm", "IterationsRequired");
                RetVal[2].AddAssociation("Exchange", "IterationsRequired");
                RetVal[3] = new UPnPModeratedStateVariable("A_ARG_TYPE_Nonce", typeof(System.String), false);
                RetVal[3].AddAssociation("Confirm", "HostConfirmNonce");
                RetVal[3].AddAssociation("Confirm", "DeviceConfirmNonce");
                RetVal[3].AddAssociation("Validate", "HostValidateNonce");
                RetVal[3].AddAssociation("Validate", "DeviceValidateNonce");
                RetVal[4] = new UPnPModeratedStateVariable("A_ARG_TYPE_Authenticator", typeof(System.String), false);
                RetVal[4].AddAssociation("Commit", "HostValidateAuthenticator");
                RetVal[4].AddAssociation("Commit", "DeviceValidateAuthenticator");
                RetVal[4].AddAssociation("Exchange", "HostConfirmAuthenticator");
                RetVal[4].AddAssociation("Exchange", "DeviceConfirmAuthenticator");
                RetVal[5] = new UPnPModeratedStateVariable("A_ARG_TYPE_Certificate", typeof(System.String), false);
                RetVal[5].AddAssociation("Exchange", "HostCertificate");
                RetVal[5].AddAssociation("Exchange", "DeviceCertificate");
                RetVal[6] = new UPnPModeratedStateVariable("A_ARG_TYPE_Iteration", typeof(System.Byte), false);
                RetVal[6].SetRange((System.Byte)(1), (System.Byte)(20), null);
                RetVal[6].AddAssociation("Commit", "Iteration");
                RetVal[6].AddAssociation("Validate", "Iteration");

                UPnPService S = new UPnPService(1, "urn:microsoft-com:serviceId:MSTA", "urn:schemas-microsoft-com:service:mstrustagreement:1", true, this);
                for (int i = 0; i < RetVal.Length; ++i)
                {
                    S.AddStateVariable(RetVal[i]);
                }
                S.AddMethod("Commit");
                S.AddMethod("Confirm");
                S.AddMethod("Exchange");
                S.AddMethod("Validate");
                return (S);
            }

            public void Commit(System.String HostID, System.Byte Iteration, System.String HostValidateAuthenticator, out System.String DeviceValidateAuthenticator)
            {
                if (Outer.External_Commit != null)
                {
                    Outer.External_Commit(HostID, Iteration, HostValidateAuthenticator, out DeviceValidateAuthenticator);
                }
                else
                {
                    Sink_Commit(HostID, Iteration, HostValidateAuthenticator, out DeviceValidateAuthenticator);
                }
            }
            public void Confirm(System.String HostID, System.Byte IterationsRequired, System.String HostConfirmNonce, out System.String DeviceConfirmNonce)
            {
                if (Outer.External_Confirm != null)
                {
                    Outer.External_Confirm(HostID, IterationsRequired, HostConfirmNonce, out DeviceConfirmNonce);
                }
                else
                {
                    Sink_Confirm(HostID, IterationsRequired, HostConfirmNonce, out DeviceConfirmNonce);
                }
            }
            public void Exchange(System.String HostID, System.String HostCertificate, System.Byte IterationsRequired, System.String HostConfirmAuthenticator, out System.String DeviceID, out System.String DeviceCertificate, out System.String DeviceConfirmAuthenticator)
            {
                if (Outer.External_Exchange != null)
                {
                    Outer.External_Exchange(HostID, HostCertificate, IterationsRequired, HostConfirmAuthenticator, out DeviceID, out DeviceCertificate, out DeviceConfirmAuthenticator);
                }
                else
                {
                    Sink_Exchange(HostID, HostCertificate, IterationsRequired, HostConfirmAuthenticator, out DeviceID, out DeviceCertificate, out DeviceConfirmAuthenticator);
                }
            }
            public void Validate(System.String HostID, System.Byte Iteration, System.String HostValidateNonce, out System.String DeviceValidateNonce)
            {
                if (Outer.External_Validate != null)
                {
                    Outer.External_Validate(HostID, Iteration, HostValidateNonce, out DeviceValidateNonce);
                }
                else
                {
                    Sink_Validate(HostID, Iteration, HostValidateNonce, out DeviceValidateNonce);
                }
            }

            public Delegate_Commit Sink_Commit;
            public Delegate_Confirm Sink_Confirm;
            public Delegate_Exchange Sink_Exchange;
            public Delegate_Validate Sink_Validate;
        }
        public TrustAgreementService()
        {
            _S = new _TrustAgreementService(this);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_EndpointID);
            _S.GetUPnPService().GetStateVariableObject("TrustState").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_TrustState);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Rounds);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Nonce);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Authenticator);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Certificate);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Iteration);
            _S.Sink_Commit = new Delegate_Commit(Commit);
            _S.Sink_Confirm = new Delegate_Confirm(Confirm);
            _S.Sink_Exchange = new Delegate_Exchange(Exchange);
            _S.Sink_Validate = new Delegate_Validate(Validate);
        }
        public TrustAgreementService(string ID)
            : this()
        {
            _S.GetUPnPService().ServiceID = ID;
        }
        public UPnPService GetUPnPService()
        {
            return (_S.GetUPnPService());
        }
        private void OnModifiedSink_A_ARG_TYPE_EndpointID(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_EndpointID != null) OnStateVariableModified_A_ARG_TYPE_EndpointID(this);
        }
        private void OnModifiedSink_TrustState(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_TrustState != null) OnStateVariableModified_TrustState(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Rounds(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Rounds != null) OnStateVariableModified_A_ARG_TYPE_Rounds(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Nonce(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Nonce != null) OnStateVariableModified_A_ARG_TYPE_Nonce(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Authenticator(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Authenticator != null) OnStateVariableModified_A_ARG_TYPE_Authenticator(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Certificate(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Certificate != null) OnStateVariableModified_A_ARG_TYPE_Certificate(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Iteration(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Iteration != null) OnStateVariableModified_A_ARG_TYPE_Iteration(this);
        }
        //}}}}} End of Code Block

        #endregion

        /// <summary>
        /// Action: Commit
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="Iteration">Associated State Variable: A_ARG_TYPE_Iteration</param>
        /// <param name="HostValidateAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        /// <param name="DeviceValidateAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        public void Commit(System.String HostID, System.Byte Iteration, System.String HostValidateAuthenticator, out System.String DeviceValidateAuthenticator)
        {
            m_logger.LogInfo("TrustAgreementService_Commit(" + HostID.ToString() + Iteration.ToString() + HostValidateAuthenticator.ToString() + ")");
            //ToDo: Add Your implementation here, and remove exception
            throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
        }
        /// <summary>
        /// Action: Confirm
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="IterationsRequired">Associated State Variable: A_ARG_TYPE_Rounds</param>
        /// <param name="HostConfirmNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        /// <param name="DeviceConfirmNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        public void Confirm(System.String HostID, System.Byte IterationsRequired, System.String HostConfirmNonce, out System.String DeviceConfirmNonce)
        {
            m_logger.LogInfo("TrustAgreementService_Confirm(" + HostID.ToString() + IterationsRequired.ToString() + HostConfirmNonce.ToString() + ")");
            //ToDo: Add Your implementation here, and remove exception
            throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
        }
        /// <summary>
        /// Action: Exchange
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="HostCertificate">Associated State Variable: A_ARG_TYPE_Certificate</param>
        /// <param name="IterationsRequired">Associated State Variable: A_ARG_TYPE_Rounds</param>
        /// <param name="HostConfirmAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        /// <param name="DeviceID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="DeviceCertificate">Associated State Variable: A_ARG_TYPE_Certificate</param>
        /// <param name="DeviceConfirmAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        public void Exchange(System.String HostID, System.String HostCertificate, System.Byte IterationsRequired, System.String HostConfirmAuthenticator, out System.String DeviceID, out System.String DeviceCertificate, out System.String DeviceConfirmAuthenticator)
        {
            m_logger.LogInfo("TrustAgreementService_Exchange(\"" + HostID.ToString() + "\",\"" + HostCertificate.ToString() + "\"," + IterationsRequired.ToString() + ",\"" + HostConfirmAuthenticator.ToString() + "\")");
            //ToDo: Add Your implementation here, and remove exception
            //throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
            DeviceID = "";
            DeviceCertificate = "";
            DeviceConfirmAuthenticator = "";
        }
        /// <summary>
        /// Action: Validate
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="Iteration">Associated State Variable: A_ARG_TYPE_Iteration</param>
        /// <param name="HostValidateNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        /// <param name="DeviceValidateNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        public void Validate(System.String HostID, System.Byte Iteration, System.String HostValidateNonce, out System.String DeviceValidateNonce)
        {
            m_logger.LogInfo("TrustAgreementService_Validate(" + HostID.ToString() + Iteration.ToString() + HostValidateNonce.ToString() + ")");
            //ToDo: Add Your implementation here, and remove exception
            throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
        }
    }
}