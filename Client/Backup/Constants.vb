Public Class Constants

    ' Telnet definitions

    Public asPROTOCOL_RAW As Integer = 1
    Public asPROTOCOL_TELNET As Integer = 2


    ' Connection definitions

    Public asCONN_DISCONNECTED As Integer = 1
    Public asCONN_LISTENING As Integer = 2
    Public asCONN_CONNECTED As Integer = 3


    ' SNMP type definitions

    Public asASN_UNDEFINED As Integer = 0
    Public asASN_INTEGER As Integer = 2
    Public asASN_INTEGER32 As Integer = 2
    Public asASN_BITS As Integer = 3
    Public asASN_OCTETSTRING As Integer = 4
    Public asASN_NULL As Integer = 5
    Public asASN_OBJECTIDENTIFIER As Integer = 6
    Public asASN_SEQUENCE As Integer = 48
    Public asASN_SEQUENCEOF As Integer = 48
    Public asASN_IPADDRESS As Integer = 64
    Public asASN_COUNTER32 As Integer = 65
    Public asASN_GAUGE32 As Integer = 66
    Public asASN_TIMETICKS As Integer = 67
    Public asASN_OPAQUE As Integer = 68
    Public asASN_COUNTER64 As Integer = 70
    Public asASN_UNSIGNED32 As Integer = 71


    'SNMP Protocol Version Definitions

    Public asASN_PROTOCOLVERSION_V1 As Integer = 1
    Public asASN_PROTOCOLVERSION_V2C As Integer = 2


    ' Error codes 

    Public asERR_SUCCESS As Integer = 0                         ' Success
    Public asERR_INVALIDPARAMETER As Integer = 1                ' Invalid parameter
    Public asERR_CREATETHREADFAILED As Integer = 2              ' Unable to create thread
    Public asERR_EVALUATIONEXPIRED As Integer = 3               ' Evaluation period has expired
    Public asERR_INVALIDLICENSE As Integer = 4                  ' License was entered, but invalid

    Public asERR_BUFFEROVERFLOW As Integer = 10                 ' Internal buffer overflow
    Public asERR_NOBYTESINBUFFER As Integer = 11                ' No more bytes in receive buffer
    Public asERR_LISTENFAILED As Integer = 12                   ' Unable to start listener
    Public asERR_NOTLISTENING As Integer = 13                   ' Socket is not listening

    Public asERR_WSAEINTR As Integer = 10004                    ' A blocking operation was interrupted by a call to WSACancelBlockingCall. 
    Public asERR_WSAEBADF As Integer = 10009                    ' The file handle supplied is not valid.
    Public asERR_WSAEACCES As Integer = 10013                   ' An attempt was made to access a socket in a way forbidden by its access permissions. 
    Public asERR_WSAEFAULT As Integer = 10014                   ' The system detected an invalid pointer address in attempting to use a pointer argument in a call.   
    Public asERR_WSAEINVAL As Integer = 10022                   ' An invalid argument was supplied. 
    Public asERR_WSAEMFILE As Integer = 10024                   ' Too many open sockets.
    Public asERR_WSAEWOULDBLOCK As Integer = 10035              ' A non-blocking socket operation could not be completed immediately.   
    Public asERR_WSAEINPROGRESS As Integer = 10036              ' A blocking operation is currently executing.  
    Public asERR_WSAEALREADY As Integer = 10037                 ' An operation was attempted on a non-blocking socket that already had an operation in progress. 
    Public asERR_WSAENOTSOCK As Integer = 10038                 ' An operation was attempted on something that is not a socket.   
    Public asERR_WSAEDESTADDRREQ As Integer = 10039             ' A required address was omitted from an operation on a socket.
    Public asERR_WSAEMSGSIZE As Integer = 10040                 ' A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram into was smaller than the datagram itself. 
    Public asERR_WSAEPROTOTYPE As Integer = 10041               ' A protocol was specified in the socket function call that does not support the semantics of the socket type requested. 
    Public asERR_WSAENOPROTOOPT As Integer = 10042              ' An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt call. 
    Public asERR_WSAEPROTONOSUPPORT As Integer = 10043          ' The requested protocol has not been configured into the system, or no implementation for it exists.
    Public asERR_WSAESOCKTNOSUPPORT As Integer = 10044          ' The support for the specified socket type does not exist in this address family.  
    Public asERR_WSAEOPNOTSUPP As Integer = 10045               ' The attempted operation is not supported for the type of object referenced.
    Public asERR_WSAEPFNOSUPPORT As Integer = 10046             ' The protocol family has not been configured into the system or no implementation for it exists.
    Public asERR_WSAEAFNOSUPPORT As Integer = 10047             ' An address incompatible with the requested protocol was used.
    Public asERR_WSAEADDRINUSE As Integer = 10048               ' Only one usage of each socket address (protocol/network address/port) is normally permitted.
    Public asERR_WSAEADDRNOTAVAIL As Integer = 10049            ' The requested address is not valid in its context.
    Public asERR_WSAENETDOWN As Integer = 10050                 ' A socket operation encountered a dead network.
    Public asERR_WSAENETUNREACH As Integer = 10051              ' A socket operation was attempted to an unreachable network.
    Public asERR_WSAENETRESET As Integer = 10052                ' The connection has been broken due to keep-alive activity detecting a failure while the operation was in progress.
    Public asERR_WSAECONNABORTED As Integer = 10053             ' An established connection was aborted by the software in your host machine.
    Public asERR_WSAECONNRESET As Integer = 10054               ' An existing connection was forcibly closed by the remote host.
    Public asERR_WSAENOBUFS As Integer = 10055                  ' An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full.
    Public asERR_WSAEISCONN As Integer = 10056                  ' A connect request was made on an already connected socket.
    Public asERR_WSAENOTCONN As Integer = 10057                 ' A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.
    Public asERR_WSAESHUTDOWN As Integer = 10058                ' A request to send or receive data was disallowed because the socket had already been shut down in that direction with a previous shutdown call.
    Public asERR_WSAETOOMANYREFS As Integer = 10059             ' Too many references to some kernel object.
    Public asERR_WSAETIMEDOUT As Integer = 10060                ' A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.
    Public asERR_WSAECONNREFUSED As Integer = 10061             ' No connection could be made because the target machine actively refused it.
    Public asERR_WSAELOOP As Integer = 10062                    ' Cannot translate name.
    Public asERR_WSAENAMETOOLONG As Integer = 10063             ' Name component or name was too long.
    Public asERR_WSAEHOSTDOWN As Integer = 10064                ' A socket operation failed because the destination host was down.
    Public asERR_WSAEHOSTUNREACH As Integer = 10065             ' A socket operation was attempted to an unreachable host.
    Public asERR_WSAENOTEMPTY As Integer = 10066                ' Cannot remove a directory that is not empty.
    Public asERR_WSAEPROCLIM As Integer = 10067                 ' A Windows Sockets implementation may have a limit on the number of applications that may use it simultaneously.
    Public asERR_WSAEUSERS As Integer = 10068                   ' Ran out of quota.
    Public asERR_WSAEDQUOT As Integer = 10069                   ' Ran out of disk quota.
    Public asERR_WSAESTALE As Integer = 10070                   ' File handle reference is no longer available.
    Public asERR_WSAEREMOTE As Integer = 10071                  ' Item is not available locally.
    Public asERR_WSASYSNOTREADY As Integer = 10091              ' WSAStartup cannot function at this time because the underlying system it uses to provide network services is currently unavailable.
    Public asERR_WSAVERNOTSUPPORTED As Integer = 10092          ' The Windows Sockets version requested is not supported.
    Public asERR_WSANOTINITIALISED As Integer = 10093           ' Either the application has not called asERR_WSAStartup, or WSAStartup failed.
    Public asERR_WSAEDISCON As Integer = 10101                  ' Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown sequence.
    Public asERR_WSAENOMORE As Integer = 10102                  ' No more results can be returned by WSALookupServiceNext.
    Public asERR_WSAECANCELLED As Integer = 10103               ' A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
    Public asERR_WSAEINVALIDPROCTABLE As Integer = 10104        ' The procedure call table is invalid.
    Public asERR_WSAEINVALIDPROVIDER As Integer = 10105         ' The requested service provider is invalid.
    Public asERR_WSAEPROVIDERFAILEDINIT As Integer = 10106      ' The requested service provider could not be loaded or initialized.  
    Public asERR_WSASYSCALLFAILURE As Integer = 10107           ' A system call that should never fail has failed.
    Public asERR_WSASERVICE_NOT_FOUND As Integer = 10108        ' No such service is known. The service cannot be found in the specified name space.
    Public asERR_WSATYPE_NOT_FOUND As Integer = 10109           ' The specified class was not found.
    Public asERR_WSA_E_NO_MORE As Integer = 10110               ' No more results can be returned by WSALookupServiceNext.
    Public asERR_WSA_E_CANCELLED As Integer = 10111             ' A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
    Public asERR_WSAEREFUSED As Integer = 10112                 ' A database query failed because it was actively refused.
    Public asERR_WSAHOST_NOT_FOUND As Integer = 11001           ' No such host is known.
    Public asERR_WSATRY_AGAIN As Integer = 11002                ' This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.
    Public asERR_WSANO_RECOVERY As Integer = 11003              ' A non-recoverable error occurred during a database lookup.
    Public asERR_WSANO_DATA As Integer = 11004                  ' The requested name is valid and was found in the database, but it does not have the correct associated data being resolved for. 
    Public asERR_WSA_QOS_RECEIVERS As Integer = 11005           ' At least one reserve has arrived. 
    Public asERR_WSA_QOS_SENDERS As Integer = 11006             ' At least one path has arrived.
    Public asERR_WSA_QOS_NO_SENDERS As Integer = 11007          ' There are no senders. 
    Public asERR_WSA_QOS_NO_RECEIVERS As Integer = 11008        ' There are no receivers.
    Public asERR_WSA_QOS_REQUEST_CONFIRMED As Integer = 11009   ' Reserve has been confirmed.
    Public asERR_WSA_QOS_ADMISSION_FAILURE As Integer = 11010   ' Error due to lack of resources.
    Public asERR_WSA_QOS_POLICY_FAILURE As Integer = 11011      ' Rejected for administrative reasons - bad credentials.
    Public asERR_WSA_QOS_BAD_STYLE As Integer = 11012           ' Unknown or conflicting style.
    Public asERR_WSA_QOS_BAD_OBJECT As Integer = 11013          ' Problem with some part of the filterspec or providerspecific buffer in general.
    Public asERR_WSA_QOS_TRAFFIC_CTRL_ERROR As Integer = 11014  ' Problem with some part of the flowspec.
    Public asERR_WSA_QOS_GENERIC_ERROR As Integer = 11015       ' General QOS error.
    Public asERR_WSA_QOS_ESERVICETYPE As Integer = 11016        ' An invalid or unrecognized service type was found in the flowspec.
    Public asERR_WSA_QOS_EFLOWSPEC As Integer = 11017           ' An invalid or inconsistent flowspec was found in the QOS structure.
    Public asERR_WSA_QOS_EPROVSPECBUF As Integer = 11018        ' Invalid QOS provider-specific buffer. 
    Public asERR_WSA_QOS_EFILTERSTYLE As Integer = 11019        ' An invalid QOS filter style was used.
    Public asERR_WSA_QOS_EFILTERTYPE As Integer = 11020         ' An invalid QOS filter type was used.
    Public asERR_WSA_QOS_EFILTERCOUNT As Integer = 11021        ' An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.
    Public asERR_WSA_QOS_EOBJLENGTH As Integer = 11022          ' An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_EFLOWCOUNT As Integer = 11023          ' An incorrect number of flow descriptors was specified in the QOS structure.
    Public asERR_WSA_QOS_EUNKNOWNPSOBJ As Integer = 11024       ' An unrecognized object was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_EPOLICYOBJ As Integer = 11025          ' An invalid policy object was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_EFLOWDESC As Integer = 11026           ' An invalid QOS flow descriptor was found in the flow descriptor list.
    Public asERR_WSA_QOS_EPSFLOWSPEC As Integer = 11027         ' An invalid or inconsistent flowspec was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_EPSFILTERSPEC As Integer = 11028       ' An invalid FILTERSPEC was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_ESDMODEOBJ As Integer = 11029          ' An invalid shape discard mode object was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_ESHAPERATEOBJ As Integer = 11030       ' An invalid shaping rate object was found in the QOS provider-specific buffer.
    Public asERR_WSA_QOS_RESERVED_PETYPE As Integer = 11031     ' A reserved policy element was found in the QOS provider-specific buffer. 


    ' Errors - SNMP related

    Public asERR_LIBSNMPAPINOTFOUND As Integer = 100                ' SNMPAPI.DLL could not be loaded because DLL was not found
    Public asERR_LIBMGMTAPINOTFOUND As Integer = 101                ' MGMTAPI.DLL could not be loaded because DLL was not found 
    Public asERR_LIBSNMPAPIBINDINGFAILURE As Integer = 102          ' One or more exported functions missing in SNMPAPI.DLL
    Public asERR_LIBMGMTAPIBINDINGFAILURE As Integer = 103          ' One or more exported functions missing in MGMTAPI.DLL
    Public asERR_LIBWSNMP2APINOTFOUND As Integer = 104	            ' WSNMP32.DLL could not be loaded because DLL was not found
    Public asERR_LIBWSNMP2APIBINDINGFAILURE As Integer = 105	    ' One or more exported functions missing in WSNMP32.DLL

    Public asERR_SNMP_LIBRARIESNOTLOADED As Integer = 110	        ' SNMP Libraries not loaded; operation not allowed
    Public asERR_SNMP_WINSNMPINITFAILED As Integer = 111	        ' Unable to intialize WinSNMP
    Public asERR_SNMP_LIBNOTINITIALIZED As Integer = 112	        ' Library not initialized. 
    Public asERR_SNMP_OPENSESSIONFAILED As Integer = 113	        ' Unable to open SNMP session
    Public asERR_SNMP_SESSIONALREADYOPENED As Integer = 114	        ' Session already opened
    Public asERR_SNMP_SESSIONNOTOPENED As Integer = 115	            ' Open a session first
    Public asERR_SNMP_MEMALLOCAFAILED As Integer = 116	            ' Memory allocation failed
    Public asERR_SNMP_INVALIDPARAM As Integer = 117	                ' Invalid parameter
    Public asERR_SNMP_REQUESTTIMEDOUT As Integer = 118              ' Request operation timed out
    Public asERR_SNMP_REQUESTFAILED As Integer = 119                ' Request operation failed
    Public asERR_SNMP_INVALIDHOST As Integer = 120                  ' Invalid hostname
    Public asERR_SNMP_INVALIDPORT As Integer = 121                  ' Unable to set port other than 161
    Public asERR_SNMP_TYPENOTSUPPORTED As Integer = 122             ' OID type not supported by ActiveSocket
    Public asERR_SNMP_ADDTRAPFAILED As Integer = 140                ' Unable to add trap
    Public asERR_SNMP_NOMOREOIDS As Integer = 141                   ' Unable to add trap
    Public asERR_SNMP_NOTRAPSTOSEND As Integer = 142                ' No traps to send. Use the Add function to add traps before calling Send

    Public asERR_SNMP_NOMORETRAPSINQUEUE As Integer = 150           ' No traps in receive queue
    Public asERR_SNMP_INVALIDOPERATION As Integer = 151	            ' Invalid call. Call GetFirstTrap before calling GetNextTrap


    ' Errors - NTP related

    Public asERR_NTP_INVALIDHOSTNAME As Integer = 200           ' Invalid NTP host name
    Public asERR_NTP_CREATESOCKETFAILED As Integer = 201        ' Create socket failed
    Public asERR_NTP_CONNECTFAILEDFAILED As Integer = 202       ' Unable to connect to NTP server
    Public asERR_NTP_TIMEREQUESTFAILED As Integer = 203         ' Connection to NTP server established, but request failed
    Public asERR_NTP_REQUESTFAILED As Integer = 204             ' Request failed
    Public asERR_NTP_NORESPONSERECEIVED As Integer = 205        ' No response received


    ' Errors - ICMP Related

    Public asERR_ICMP_CREATESOCKETFAILED As Integer = 300       ' Creation of socket failed
    Public asERR_ICMP_INVALIDHOSTNAME As Integer = 301          ' Invalid host name
    Public asERR_ICMP_TIMEOUT As Integer = 302	                ' Timeout
    Public asERR_ICMP_HOSTUNREACHABLE As Integer = 303	        ' Destination host unreachable
    Public asERR_ICMP_NETUNREACHABLE As Integer = 304	        ' Destination net unreachable
    Public asERR_ICMP_INTERNALAPIERROR As Integer = 307         ' Internal API error
    Public asERR_ICMP_BADOPTION As Integer = 308	            ' Bad option
    Public asERR_ICMP_HWFAILED As Integer = 309	                ' Hardware error
    Public asERR_ICMP_PACKETTOOBIG As Integer = 310	            ' Packet too big
    Public asERR_ICMP_BADREQUEST As Integer = 311	            ' Bad request
    Public asERR_ICMP_BADROUTE As Integer = 312	                ' Bad route
    Public asERR_ICMP_TTLEXPIRED As Integer = 313	            ' TTL expired
    Public asERR_ICMP_SOURCEQUENCH As Integer = 314	            ' Source Quench
    Public asERR_ICMP_BADDESTINATION As Integer = 315           ' Bad Destination


    ' Errors - HTTP Related

    Public asERR_HTTP_LOADWINHTTPFAILED As Integer = 400        ' Unable to load WinHTTP libraries
    Public asERR_HTTP_CREATESESSIONFAILED As Integer = 401      ' Create WinHTTP session failed
    Public asERR_HTTP_SESSIONNOTOPENED As Integer = 402         ' Open a session first
    Public asERR_HTTP_ALREADYCONNECTED As Integer = 403         ' Connection already established
    Public asERR_HTTP_OPENCONNECTIONFAILED As Integer = 404     ' Unable to establish a connection to remote web server
    Public asERR_HTTP_SETPROXYCREDENTIALSFAILED As Integer = 405 ' Unable to logon to proxy
    Public asERR_HTTP_SENDREQUESTFAILED As Integer = 406        ' Unable to send the request to the remote web server
    Public asERR_HTTP_NORESPONSERECEIVED As Integer = 407       ' No response received from remote server
    Public asERR_HTTP_QUERYHEADERSFAILED As Integer = 408       ' Unable to query headers
    Public asERR_HTTP_QUERYAUTHSCHEMESFAILED As Integer = 409   ' Unable to query authentication schemes
    Public asERR_HTTP_OPENCONNECTIONTIMEOUT As Integer = 410    ' Unable to establish connection, operation timed out
    Public asERR_HTTP_CONNECTIONNOTOPENED As Integer = 411      ' Establish a connection first
    Public asERR_HTTP_SETCREDENTIALSFAILED As Integer = 412     ' Unable to logon to web site
    Public asERR_HTTP_QUERYDATASIZEFAILED As Integer = 413      ' Unable to read data, query for data size failed
    Public asERR_HTTP_DATAALLOCATIONFAILED As Integer = 414     ' Unable to read data, internal memory allocation failed
    Public asERR_HTTP_READFAILED As Integer = 415               ' Unable to read data, read operation failed

    Public asERR_WOL_INVALIDMACADDRESS As Integer = 500         ' Invalid MAC address

End Class

