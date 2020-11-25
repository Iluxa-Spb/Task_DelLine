declare @dayportion float;
declare @substringlength int;
set @dayportion=-1.0;
set @substringlength=200;

SELECT TOP (15) 
    sum(total_logical_reads) 'Total Logical Reads', 
    sum(total_logical_writes) 'Total Logical Writes',
    sum(total_worker_time) 'Total CPU',
    sum(execution_count) 'Count',
    sum(total_logical_reads) * 100 / (select sum(total_logical_reads) from sys.dm_exec_query_stats where last_execution_time > dateadd(day, @dayportion, getdate())) 'Pct of Reads',
    sum(total_logical_writes) * 100 / (select sum(total_logical_writes) from sys.dm_exec_query_stats where last_execution_time > dateadd(day, @dayportion, getdate())) 'Pct of Writes',
    sum(total_worker_time) * 100 / (select sum(total_worker_time) from sys.dm_exec_query_stats where last_execution_time > dateadd(day, @dayportion, getdate())) 'Pct of CPU',
    sum(total_logical_reads) / sum(execution_count) 'Avg Reads',
    sum(total_logical_writes) / sum(execution_count) 'Avg Writes',
    sum(total_worker_time) / sum(execution_count) 'Avg CPU',
    statement_text
FROM (
        select 
        total_logical_reads, 
        total_logical_writes,
        total_worker_time,
        execution_count,
        substring(SUBSTRING(st.text, (qs.statement_start_offset/2)+1, 
            ((CASE qs.statement_end_offset
              WHEN -1 THEN DATALENGTH(st.text)
             ELSE qs.statement_end_offset
             END - qs.statement_start_offset)/2) + 1), 0, @substringlength) as statement_text
        FROM sys.dm_exec_query_stats qs 
        CROSS APPLY sys.dm_exec_sql_text(qs.sql_handle) st
        WHERE last_execution_time > dateadd(day, @dayportion, getdate())
) x
group by statement_text
ORDER BY 'Pct of CPU' DESC