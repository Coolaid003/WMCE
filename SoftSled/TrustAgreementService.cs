using Intel.UPNP;
using SoftSled.Components;

namespace SoftSled {
    /// <summary>
    /// Transparent DeviceSide UPnP Service
    /// </summary>
    public class TrustAgreementService : IUPnPService {

        private Logger m_logger;

        public Delegate_Commit External_Commit = null;
        public Delegate_Confirm External_Confirm = null;
        public Delegate_Exchange External_Exchange = null;
        public Delegate_Validate External_Validate = null;

        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_EndpointID;
        public event OnStateVariableModifiedHandler OnStateVariableModified_TrustState;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Rounds;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Nonce;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Authenticator;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Certificate;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Iteration;

        public TrustAgreementService(Logger logger) : this() {
            m_logger = logger;
        }

        #region AutoGenerated Code Section ####################################

        private _TrustAgreementService _S;
        public static string URN = "urn:schemas-microsoft-com:service:mstrustagreement:1";
        public double VERSION {
            get {
                return double.Parse(_S.GetUPnPService().Version);
            }
        }

       
        public string A_ARG_TYPE_EndpointID {
            get {
                return (string)_S.GetStateVariable("A_ARG_TYPE_EndpointID");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_EndpointID", value);
            }
        }
        public byte TrustState {
            get {
                return (byte)_S.GetStateVariable("TrustState");
            }
            set {
                _S.SetStateVariable("TrustState", value);
            }
        }
        public byte A_ARG_TYPE_Rounds {
            get {
                return (byte)_S.GetStateVariable("A_ARG_TYPE_Rounds");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_Rounds", value);
            }
        }
        public string A_ARG_TYPE_Nonce {
            get {
                return (string)_S.GetStateVariable("A_ARG_TYPE_Nonce");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_Nonce", value);
            }
        }
        public string A_ARG_TYPE_Authenticator {
            get {
                return (string)_S.GetStateVariable("A_ARG_TYPE_Authenticator");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_Authenticator", value);
            }
        }
        public string A_ARG_TYPE_Certificate {
            get {
                return (string)_S.GetStateVariable("A_ARG_TYPE_Certificate");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_Certificate", value);
            }
        }
        public byte A_ARG_TYPE_Iteration {
            get {
                return (byte)_S.GetStateVariable("A_ARG_TYPE_Iteration");
            }
            set {
                _S.SetStateVariable("A_ARG_TYPE_Iteration", value);
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_EndpointID {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_EndpointID {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_TrustState {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).Accumulator = value;
            }
        }
        public double ModerationDuration_TrustState {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("TrustState")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Rounds {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Rounds {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Nonce {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Nonce {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Authenticator {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Authenticator {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Certificate {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Certificate {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate")).ModerationPeriod = value;
            }
        }
        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Iteration {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).Accumulator;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).Accumulator = value;
            }
        }
        public double ModerationDuration_A_ARG_TYPE_Iteration {
            get {
                return ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).ModerationPeriod;
            }
            set {
                ((UPnPModeratedStateVariable)_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration")).ModerationPeriod = value;
            }
        }


        #region Define Delegates ##############################################

        public delegate void OnStateVariableModifiedHandler(TrustAgreementService sender);

        public delegate void Delegate_Exchange(string HostID, string HostCertificate, byte IterationsRequired, string HostConfirmAuthenticator, out string DeviceID, out string DeviceCertificate, out string DeviceConfirmAuthenticator);
        public delegate void Delegate_Commit(string HostID, byte Iteration, string HostValidateAuthenticator, out string DeviceValidateAuthenticator);
        public delegate void Delegate_Validate(string HostID, byte Iteration, string HostValidateNonce, out string DeviceValidateNonce);
        public delegate void Delegate_Confirm(string HostID, byte IterationsRequired, string HostConfirmNonce, out string DeviceConfirmNonce);

        #endregion ############################################################


        public void RemoveStateVariable_A_ARG_TYPE_EndpointID() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID"));
        }
        public void RemoveStateVariable_TrustState() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("TrustState"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Rounds() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Nonce() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Authenticator() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Certificate() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate"));
        }
        public void RemoveStateVariable_A_ARG_TYPE_Iteration() {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration"));
        }
        public void RemoveAction_Commit() {
            _S.GetUPnPService().RemoveMethod("Commit");
        }
        public void RemoveAction_Confirm() {
            _S.GetUPnPService().RemoveMethod("Confirm");
        }
        public void RemoveAction_Exchange() {
            _S.GetUPnPService().RemoveMethod("Exchange");
        }
        public void RemoveAction_Validate() {
            _S.GetUPnPService().RemoveMethod("Validate");
        }
        public System.Net.IPEndPoint GetCaller() {
            return (_S.GetUPnPService().GetCaller());
        }
        public System.Net.IPEndPoint GetReceiver() {
            return (_S.GetUPnPService().GetReceiver());
        }

        private class _TrustAgreementService {

            public Delegate_Commit Sink_Commit;
            public Delegate_Confirm Sink_Confirm;
            public Delegate_Exchange Sink_Exchange;
            public Delegate_Validate Sink_Validate;

            private TrustAgreementService Outer = null;

            private UPnPService S;
            internal _TrustAgreementService(TrustAgreementService n) {
                Outer = n;
                S = BuildUPnPService();
            }
            public UPnPService GetUPnPService() {
                return (S);
            }
            public void SetStateVariable(string VarName, object VarValue) {
                S.SetStateVariable(VarName, VarValue);
            }
            public object GetStateVariable(string VarName) {
                return (S.GetStateVariable(VarName));
            }
            protected UPnPService BuildUPnPService() {
                UPnPStateVariable[] RetVal = new UPnPStateVariable[7];
                RetVal[0] = new UPnPModeratedStateVariable("A_ARG_TYPE_EndpointID", typeof(string), false);
                RetVal[0].AddAssociation("Exchange", "HostID");
                RetVal[0].AddAssociation("Exchange", "DeviceID");
                RetVal[0].AddAssociation("Validate", "HostID");
                RetVal[0].AddAssociation("Commit", "HostID");
                RetVal[0].AddAssociation("Confirm", "HostID");
                RetVal[1] = new UPnPModeratedStateVariable("TrustState", typeof(byte), false);
                RetVal[1].SetRange((byte)(0), (byte)(4), null);
                RetVal[2] = new UPnPModeratedStateVariable("A_ARG_TYPE_Rounds", typeof(byte), false);
                RetVal[2].SetRange((byte)(2), (byte)(20), null);
                RetVal[2].AddAssociation("Exchange", "IterationsRequired");
                RetVal[2].AddAssociation("Confirm", "IterationsRequired");
                RetVal[3] = new UPnPModeratedStateVariable("A_ARG_TYPE_Nonce", typeof(string), false);
                RetVal[3].AddAssociation("Validate", "HostValidateNonce");
                RetVal[3].AddAssociation("Validate", "DeviceValidateNonce");
                RetVal[3].AddAssociation("Confirm", "HostConfirmNonce");
                RetVal[3].AddAssociation("Confirm", "DeviceConfirmNonce");
                RetVal[4] = new UPnPModeratedStateVariable("A_ARG_TYPE_Authenticator", typeof(string), false);
                RetVal[4].AddAssociation("Exchange", "HostConfirmAuthenticator");
                RetVal[4].AddAssociation("Exchange", "DeviceConfirmAuthenticator");
                RetVal[4].AddAssociation("Commit", "HostValidateAuthenticator");
                RetVal[4].AddAssociation("Commit", "DeviceValidateAuthenticator");
                RetVal[5] = new UPnPModeratedStateVariable("A_ARG_TYPE_Certificate", typeof(string), false);
                RetVal[5].AddAssociation("Exchange", "HostCertificate");
                RetVal[5].AddAssociation("Exchange", "DeviceCertificate");
                RetVal[6] = new UPnPModeratedStateVariable("A_ARG_TYPE_Iteration", typeof(byte), false);
                RetVal[6].SetRange((byte)(1), (byte)(20), null);
                RetVal[6].AddAssociation("Commit", "Iteration");
                RetVal[6].AddAssociation("Validate", "Iteration");

                UPnPService S = new UPnPService(1, "urn:microsoft-com:serviceId:MSTA", "urn:schemas-microsoft-com:service:mstrustagreement:1", true, this);
                for (int i = 0; i < RetVal.Length; ++i) {
                    S.AddStateVariable(RetVal[i]);
                }
                S.AddMethod("Exchange");
                S.AddMethod("Commit");
                S.AddMethod("Validate");
                S.AddMethod("Confirm");
                return (S);
            }


            public void Exchange(string HostID, string HostCertificate, byte IterationsRequired, string HostConfirmAuthenticator, out string DeviceID, out string DeviceCertificate, out string DeviceConfirmAuthenticator) {
                if (Outer.External_Exchange != null) {
                    Outer.External_Exchange(HostID, HostCertificate, IterationsRequired, HostConfirmAuthenticator, out DeviceID, out DeviceCertificate, out DeviceConfirmAuthenticator);
                } else {
                    Sink_Exchange(HostID, HostCertificate, IterationsRequired, HostConfirmAuthenticator, out DeviceID, out DeviceCertificate, out DeviceConfirmAuthenticator);
                }
            }
            public void Commit(string HostID, byte Iteration, string HostValidateAuthenticator, out string DeviceValidateAuthenticator) {
                if (Outer.External_Commit != null) {
                    Outer.External_Commit(HostID, Iteration, HostValidateAuthenticator, out DeviceValidateAuthenticator);
                } else {
                    Sink_Commit(HostID, Iteration, HostValidateAuthenticator, out DeviceValidateAuthenticator);
                }
            }
            public void Validate(string HostID, byte Iteration, string HostValidateNonce, out string DeviceValidateNonce) {
                if (Outer.External_Validate != null) {
                    Outer.External_Validate(HostID, Iteration, HostValidateNonce, out DeviceValidateNonce);
                } else {
                    Sink_Validate(HostID, Iteration, HostValidateNonce, out DeviceValidateNonce);
                }
            }
            public void Confirm(string HostID, byte IterationsRequired, string HostConfirmNonce, out string DeviceConfirmNonce) {
                if (Outer.External_Confirm != null) {
                    Outer.External_Confirm(HostID, IterationsRequired, HostConfirmNonce, out DeviceConfirmNonce);
                } else {
                    Sink_Confirm(HostID, IterationsRequired, HostConfirmNonce, out DeviceConfirmNonce);
                }
            }

            
        }
        public TrustAgreementService() {
            _S = new _TrustAgreementService(this);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_EndpointID").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_EndpointID);
            _S.GetUPnPService().GetStateVariableObject("TrustState").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_TrustState);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Rounds").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Rounds);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Nonce").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Nonce);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Authenticator").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Authenticator);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Certificate").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Certificate);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Iteration").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Iteration);
            _S.Sink_Exchange = new Delegate_Exchange(Exchange);
            _S.Sink_Commit = new Delegate_Commit(Commit);
            _S.Sink_Validate = new Delegate_Validate(Validate);
            _S.Sink_Confirm = new Delegate_Confirm(Confirm);
        }
        public TrustAgreementService(string ID)
            : this() {
            _S.GetUPnPService().ServiceID = ID;
        }
        public UPnPService GetUPnPService() {
            return (_S.GetUPnPService());
        }
        private void OnModifiedSink_A_ARG_TYPE_EndpointID(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_EndpointID?.Invoke(this);
        }
        private void OnModifiedSink_TrustState(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_TrustState?.Invoke(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Rounds(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_Rounds?.Invoke(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Nonce(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_Nonce?.Invoke(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Authenticator(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_Authenticator?.Invoke(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Certificate(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_Certificate?.Invoke(this);
        }
        private void OnModifiedSink_A_ARG_TYPE_Iteration(UPnPStateVariable sender, object NewValue) {
            OnStateVariableModified_A_ARG_TYPE_Iteration?.Invoke(this);
        }


        #endregion ############################################################

        #region Code Section ##################################################

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
        public void Exchange(string HostID, string HostCertificate, byte IterationsRequired, string HostConfirmAuthenticator, out string DeviceID, out string DeviceCertificate, out string DeviceConfirmAuthenticator) {
            System.Diagnostics.Debug.WriteLine("here");
            m_logger.LogInfo("TrustAgreementService_Exchange(\"" + HostID.ToString() + "\",\"" + HostCertificate.ToString() + "\"," + IterationsRequired.ToString() + ",\"" + HostConfirmAuthenticator.ToString() + "\")");
            //ToDo: Add Your implementation here, and remove exception
            //throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
            DeviceID = "";
            DeviceCertificate = "";
            DeviceConfirmAuthenticator = "";
        }
        /// <summary>
        /// Action: Commit
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="Iteration">Associated State Variable: A_ARG_TYPE_Iteration</param>
        /// <param name="HostValidateAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        /// <param name="DeviceValidateAuthenticator">Associated State Variable: A_ARG_TYPE_Authenticator</param>
        public void Commit(string HostID, byte Iteration, string HostValidateAuthenticator, out string DeviceValidateAuthenticator) {
            m_logger.LogInfo("TrustAgreementService_Commit(" + HostID.ToString() + Iteration.ToString() + HostValidateAuthenticator.ToString() + ")");
            //ToDo: Add Your implementation here, and remove exception
            throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
        }
        /// <summary>
        /// Action: Validate
        /// </summary>
        /// <param name="HostID">Associated State Variable: A_ARG_TYPE_EndpointID</param>
        /// <param name="Iteration">Associated State Variable: A_ARG_TYPE_Iteration</param>
        /// <param name="HostValidateNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        /// <param name="DeviceValidateNonce">Associated State Variable: A_ARG_TYPE_Nonce</param>
        public void Validate(string HostID, byte Iteration, string HostValidateNonce, out string DeviceValidateNonce) {
            m_logger.LogInfo("TrustAgreementService_Validate(" + HostID.ToString() + Iteration.ToString() + HostValidateNonce.ToString() + ")");
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
        public void Confirm(string HostID, byte IterationsRequired, string HostConfirmNonce, out string DeviceConfirmNonce) {
            m_logger.LogInfo("TrustAgreementService_Confirm(" + HostID.ToString() + IterationsRequired.ToString() + HostConfirmNonce.ToString() + ")");
            //ToDo: Add Your implementation here, and remove exception
            throw (new UPnPCustomException(800, "This method has not been completely implemented..."));
        }

        #endregion ############################################################
    }
}