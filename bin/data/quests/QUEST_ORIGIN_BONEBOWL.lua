QUEST_ORIGIN_BONEBOWL = {
	title = 'IDS_PROPQUEST_INC_000966',
	character = 'MaSa_QueerCollector',
	start_requirements = {
		min_level = 44,
		max_level = 60,
		job = { 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN' },
	},
	rewards = {
		gold = 0,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_000967',
			'IDS_PROPQUEST_INC_000968',
			'IDS_PROPQUEST_INC_000969',
			'IDS_PROPQUEST_INC_000970',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_000971',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_000972',
		},
		completed = {
			'IDS_PROPQUEST_INC_000973',
			'IDS_PROPQUEST_INC_000974',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_000975',
		},
	}
}