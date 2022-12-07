#region License
/* 
 * Copyright (C) 1999-2022 John Källén.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

namespace Reko.Arch.Pdp.Pdp10
{
    public enum Mnemonic
    {
        Invalid,
        Nyi,

        add,
        addb,
        addi,
        addm,
        adjsp,
        and,
        andb,
        andca,
        andcab,
        andcai,
        andcam,
        andcb,
        andcbb,
        andcbi,
        andcbm,
        andcm,
        andcmb,
        andcmi,
        andcmm,
        andi,
        andm,
        aobjn,
        aobjp,
        aoj,
        aoja,
        aoje,
        aojg,
        aojge,
        aojl,
        aojle,
        aojn,
        aos,
        aosa,
        aose,
        aosg,
        aosge,
        aosl,
        aosle,
        aosn,
        ash,
        ashc,
        blki,
        blko,
        blt,
        cai,
        caia,
        caie,
        caig,
        caige,
        cail,
        caile,
        cain,
        call,
        calli,
        cam,
        cama,
        came,
        camg,
        camge,
        caml,
        camle,
        camn,
        close,
        coni,
        cono,
        conso,
        consz,
        dadd,
        datai,
        datao,
        ddiv,
        dfad,
        dfdv,
        dfmp,
        dfn,
        dfsb,
        div,
        divb,
        divi,
        divm,
        dmove,
        dmovem,
        dmovn,
        dmovnm,
        dmul,
        dpb,
        dsub,
        enter,
        eqv,
        eqvb,
        eqvi,
        eqvm,
        exch,
        extend,
        fad,
        fadb,
        fadl,
        fadm,
        fadr,
        fadrb,
        fadrl,
        fadrm,
        fdv,
        fdvb,
        fdvl,
        fdvm,
        fdvr,
        fdvrb,
        fdvrl,
        fdvrm,
        fix,
        fixr,
        fltr,
        fmp,
        fmpb,
        fmpl,
        fmpm,
        fmpr,
        fmprb,
        fmprl,
        fmprm,
        fsb,
        fsbb,
        fsbl,
        fsbm,
        fsbr,
        fsbrb,
        fsbrl,
        fsbrm,
        fsc,
        getsts,
        gfad,
        gfdv,
        gfmp,
        gfsb,
        hll,
        hlle,
        hllei,
        hllem,
        hlles,
        hllm,
        hllo,
        hlloi,
        hllom,
        hllos,
        hlls,
        hllz,
        hllzi,
        hllzm,
        hllzs,
        hlr,
        hlre,
        hlrei,
        hlrem,
        hlres,
        hlri,
        hlrm,
        hlro,
        hlroi,
        hlrom,
        hlros,
        hlrs,
        hlrz,
        hlrzi,
        hlrzm,
        hlrzs,
        hrl,
        hrle,
        hrlei,
        hrlem,
        hrles,
        hrli,
        hrlm,
        hrlo,
        hrloi,
        hrlom,
        hrlos,
        hrls,
        hrlz,
        hrlzi,
        hrlzm,
        hrlzs,
        hrr,
        hrre,
        hrrei,
        hrrem,
        hrres,
        hrri,
        hrrm,
        hrro,
        hrroi,
        hrrom,
        hrros,
        hrrs,
        hrrz,
        hrrzi,
        hrrzm,
        hrrzs,
        ibp,
        idiv,
        idivb,
        idivi,
        idivm,
        idpb,
        ildb,
        imul,
        imulb,
        imuli,
        imulm,
        @in,
        inbuf,
        initi,
        input,
        jcry,
        jcry0,
        jcry1,
        jfcl,
        jffo,
        jfov,
        jov,
        jra,
        jrst,
        jsa,
        jsp,
        jsr,
        jsys,
        jump,
        jumpa,
        jumpe,
        jumpg,
        jumpge,
        jumpl,
        jumple,
        jumpn,
        ldb,
        lookup,
        lsh,
        lshc,
        luuo01,
        luuo02,
        luuo03,
        luuo04,
        luuo05,
        luuo06,
        luuo07,
        luuo10,
        luuo11,
        luuo12,
        luuo13,
        luuo14,
        luuo15,
        luuo16,
        luuo17,
        luuo20,
        luuo21,
        luuo22,
        luuo23,
        luuo24,
        luuo25,
        luuo26,
        luuo27,
        luuo30,
        luuo31,
        luuo32,
        luuo33,
        luuo34,
        luuo35,
        luuo36,
        luuo37,
        map,
        move,
        movei,
        movem,
        moves,
        movm,
        movmi,
        movmm,
        movms,
        movn,
        movni,
        movnm,
        movns,
        movs,
        movsi,
        movsm,
        movss,
        mtape,
        mul,
        mulb,
        muli,
        mulm,
        muuo42,
        muuo43,
        muuo44,
        muuo45,
        muuo46,
        muuo52,
        muuo53,
        muuo54,
        open,
        or,
        orb,
        orca,
        orcab,
        orcai,
        orcam,
        orcb,
        orcbb,
        orcbi,
        orcbm,
        orcm,
        orcmb,
        orcmi,
        orcmm,
        ori,
        orm,
        @out,
        outbuf,
        output,
        pop,
        popj,
        push,
        pushj,
        releas,
        rename,
        rot,
        rotc,
        seta,
        setab,
        setai,
        setam,
        setca,
        setcab,
        setcai,
        setcam,
        setcm,
        setcmb,
        setcmi,
        setcmm,
        setm,
        setmb,
        setmm,
        seto,
        setob,
        setoi,
        setom,
        setsts,
        setz,
        setzb,
        setzi,
        setzm,
        skip,
        skipa,
        skipe,
        skipg,
        skipge,
        skipl,
        skiple,
        skipn,
        soj,
        soja,
        soje,
        sojg,
        sojge,
        sojl,
        sojle,
        sojn,
        sos,
        sosa,
        sose,
        sosg,
        sosge,
        sosl,
        sosle,
        sosn,
        stato,
        status,
        sub,
        subb,
        subi,
        subm,
        tdc,
        tdca,
        tdce,
        tdcn,
        tdn,
        tdna,
        tdne,
        tdnn,
        tdo,
        tdoa,
        tdoe,
        tdon,
        tdz,
        tdza,
        tdze,
        tdzn,
        tlc,
        tlca,
        tlce,
        tlcn,
        tln,
        tlna,
        tlne,
        tlnn,
        tlo,
        tloa,
        tloe,
        tlon,
        tlz,
        tlza,
        tlze,
        tlzn,
        trc,
        trca,
        trce,
        trcn,
        trn,
        trna,
        trne,
        trnn,
        tro,
        troa,
        troe,
        tron,
        trz,
        trza,
        trze,
        trzn,
        tsc,
        tsca,
        tsce,
        tscn,
        tsn,
        tsna,
        tsne,
        tsnn,
        tso,
        tsoa,
        tsoe,
        tson,
        tsz,
        tsza,
        tsze,
        tszn,
        ttcall,
        ufa,
        ugetf,
        ujen,
        useti,
        useto,
        xct,
        xhlli,
        xmovei,
        xor,
        xorb,
        xori,
        xorm,
        portal,
        xjrstf,
        halt,
        jrstf,
        xjen,
        xpcw,
        sfm,
        jen,
    }
}