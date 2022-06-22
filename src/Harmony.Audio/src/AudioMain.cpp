#include "pch.h"
#include <iostream>
#include "AudioMain.h"


bool audio::init(const unsigned long long a, const unsigned long long b)
{
    pj::Endpoint* ep = new pj::Endpoint;
    try {
       ep->libCreate();
    }
    catch (pj::Error& err) {
        std::cout << "Startup error: " << err.info() << std::endl;
        return false;
    }
    try {
        pj::TransportConfig tcfg;
        tcfg.port = 5060;
        pj::TransportId tid = ep->transportCreate(PJSIP_TRANSPORT_UDP, tcfg);
    }
    catch (pj::Error& err) {
        std::cout << "Transport creation error: " << err.info() << std::endl;
        return false;
    }
    try {
        ep->libStart();
    }
    catch (pj::Error& err) {
        std::cout << "Startup error: " << err.info() << std::endl;
        return false;
    }
    ep->libDestroy();
    delete ep;
    return true;
}
